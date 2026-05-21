-- MySQL schema for "db_toko" used by the application
-- Run as a user with CREATE DATABASE / CREATE TABLE privileges.

CREATE DATABASE IF NOT EXISTS `db_toko`
  CHARACTER SET = utf8mb4
  COLLATE = utf8mb4_general_ci;
USE `db_toko`;

-- =========================
-- users
-- =========================
CREATE TABLE IF NOT EXISTS `users` (
  `id_user` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `username` VARCHAR(50) NOT NULL UNIQUE,
  `password` VARCHAR(255) NOT NULL,
  `nama_lengkap` VARCHAR(200) NOT NULL,
  `level` VARCHAR(50) NOT NULL DEFAULT 'User',
  `status` VARCHAR(20) NOT NULL DEFAULT 'Aktif',
  `created_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Default admin (password in code uses plain text "12345" — adjust to hashed in production)
INSERT IGNORE INTO `users` (`username`,`password`,`nama_lengkap`,`level`,`status`)
VALUES ('admin','12345','Administrator','Administrator','Aktif');

-- =========================
-- kategori
-- =========================
CREATE TABLE IF NOT EXISTS `kategori` (
  `kode_kategori` VARCHAR(10) NOT NULL PRIMARY KEY,
  `nama_kategori` VARCHAR(100) NOT NULL,
  `keterangan` TEXT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- =========================
-- supplier
-- =========================
CREATE TABLE IF NOT EXISTS `supplier` (
  `kode_supplier` VARCHAR(10) NOT NULL PRIMARY KEY,
  `nama_supplier` VARCHAR(200) NOT NULL,
  `telepon` VARCHAR(50),
  `kota` VARCHAR(100)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- =========================
-- pelanggan
-- =========================
CREATE TABLE IF NOT EXISTS `pelanggan` (
  `kode_pelanggan` VARCHAR(10) NOT NULL PRIMARY KEY,
  `nama_pelanggan` VARCHAR(200) NOT NULL,
  `telepon` VARCHAR(50),
  `alamat` TEXT,
  `email` VARCHAR(200),
  `created_at` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- =========================
-- barang
-- =========================
CREATE TABLE IF NOT EXISTS `barang` (
  `kode_barang` VARCHAR(20) NOT NULL PRIMARY KEY,
  `nama_barang` VARCHAR(255) NOT NULL,
  `kode_kategori` VARCHAR(10),
  `ukuran` VARCHAR(50),
  `warna` VARCHAR(50),
  `harga` DECIMAL(15,2) NOT NULL DEFAULT 0,
  `stok` INT NOT NULL DEFAULT 0,
  `stok_minimum` INT NOT NULL DEFAULT 0,
  `satuan` VARCHAR(50) DEFAULT 'pcs',
  CONSTRAINT `fk_barang_kategori` FOREIGN KEY (`kode_kategori`) REFERENCES `kategori`(`kode_kategori`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- =========================
-- pembelian + detail_pembelian
-- =========================
CREATE TABLE IF NOT EXISTS `pembelian` (
  `id_pembelian` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `no_pembelian` VARCHAR(50) NOT NULL UNIQUE,
  `kode_supplier` VARCHAR(10),
  `tgl_pembelian` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `total` DECIMAL(15,2) NOT NULL DEFAULT 0,
  `ongkir` DECIMAL(15,2) NOT NULL DEFAULT 0,
  `created_by` VARCHAR(50),
  `remarks` TEXT,
  CONSTRAINT `fk_pembelian_supplier` FOREIGN KEY (`kode_supplier`) REFERENCES `supplier`(`kode_supplier`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `detail_pembelian` (
  `id_detail` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `id_pembelian` INT UNSIGNED NOT NULL,
  `kode_barang` VARCHAR(20),
  `nama_barang` VARCHAR(255),
  `qty` INT NOT NULL DEFAULT 0,
  `harga_satuan` DECIMAL(15,2) NOT NULL DEFAULT 0,
  `subtotal` DECIMAL(15,2) NOT NULL DEFAULT 0,
  CONSTRAINT `fk_detailpembelian_pembelian` FOREIGN KEY (`id_pembelian`) REFERENCES `pembelian`(`id_pembelian`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_detailpembelian_barang` FOREIGN KEY (`kode_barang`) REFERENCES `barang`(`kode_barang`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- =========================
-- penjualan + detail_penjualan
-- =========================
CREATE TABLE IF NOT EXISTS `penjualan` (
  `id_penjualan` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `no_transaksi` VARCHAR(50) NOT NULL UNIQUE,
  `kode_pelanggan` VARCHAR(10),
  `tgl_penjualan` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `total` DECIMAL(15,2) NOT NULL DEFAULT 0,
  `diskon` DECIMAL(15,2) NOT NULL DEFAULT 0,
  `grand_total` DECIMAL(15,2) NOT NULL DEFAULT 0,
  `created_by` VARCHAR(50),
  CONSTRAINT `fk_penjualan_pelanggan` FOREIGN KEY (`kode_pelanggan`) REFERENCES `pelanggan`(`kode_pelanggan`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `detail_penjualan` (
  `id_detail` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `id_penjualan` INT UNSIGNED NOT NULL,
  `kode_barang` VARCHAR(20),
  `nama_barang` VARCHAR(255),
  `qty` INT NOT NULL DEFAULT 0,
  `harga` DECIMAL(15,2) NOT NULL DEFAULT 0,
  `subtotal` DECIMAL(15,2) NOT NULL DEFAULT 0,
  CONSTRAINT `fk_detailpenjualan_penjualan` FOREIGN KEY (`id_penjualan`) REFERENCES `penjualan`(`id_penjualan`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_detailpenjualan_barang` FOREIGN KEY (`kode_barang`) REFERENCES `barang`(`kode_barang`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- =========================
-- laporan harian
-- =========================
CREATE OR REPLACE VIEW `laporan_harian` AS
SELECT 
    DATE(p.tgl_penjualan) AS `tanggal`,
    COUNT(DISTINCT p.id_penjualan) AS `total_transaksi`,
    SUM(dp.qty) AS `total_barang_terjual`,
    SUM(p.total) AS `total_kotor`,
    SUM(p.diskon) AS `total_diskon`,
    SUM(p.grand_total) AS `total_pendapatan_bersih`
FROM 
    `penjualan` p
LEFT JOIN 
    `detail_penjualan` dp ON p.id_penjualan = dp.id_penjualan
GROUP BY 
    DATE(p.tgl_penjualan);

-- =========================
-- Useful indexes
-- =========================
DELIMITER $$
CREATE PROCEDURE ensure_indexes()
BEGIN
  IF (SELECT COUNT(*) FROM information_schema.statistics
      WHERE table_schema = DATABASE() AND table_name = 'barang' AND index_name = 'idx_barang_stok') = 0 THEN
    SET @s = 'CREATE INDEX idx_barang_stok ON `barang` (`stok`)';
    PREPARE pst FROM @s; EXECUTE pst; DEALLOCATE PREPARE pst;
  END IF;

  IF (SELECT COUNT(*) FROM information_schema.statistics
      WHERE table_schema = DATABASE() AND table_name = 'penjualan' AND index_name = 'idx_penjualan_tgl') = 0 THEN
    SET @s = 'CREATE INDEX idx_penjualan_tgl ON `penjualan` (`tgl_penjualan`)';
    PREPARE pst FROM @s; EXECUTE pst; DEALLOCATE PREPARE pst;
  END IF;

  IF (SELECT COUNT(*) FROM information_schema.statistics
      WHERE table_schema = DATABASE() AND table_name = 'pembelian' AND index_name = 'idx_pembelian_tgl') = 0 THEN
    SET @s = 'CREATE INDEX idx_pembelian_tgl ON `pembelian` (`tgl_pembelian`)';
    PREPARE pst FROM @s; EXECUTE pst; DEALLOCATE PREPARE pst;
  END IF;
END $$
CALL ensure_indexes();
DROP PROCEDURE ensure_indexes;
DELIMITER ;

-- =========================
-- VIEWS used by forms
-- =========================
-- v_stok_barang used by FormStokBarang
DROP VIEW IF EXISTS `v_stok_barang`;
CREATE VIEW `v_stok_barang` AS
SELECT
  b.kode_barang,
  b.nama_barang,
  b.stok,
  b.stok_minimum,
  b.satuan,
  CASE WHEN b.stok <= b.stok_minimum THEN 'MENIPIS' ELSE 'AMAN' END AS status_stok
FROM barang b;

-- v_dashboard used by FormDashboard
DROP VIEW IF EXISTS `v_dashboard`;
CREATE VIEW `v_dashboard` AS
SELECT
  (SELECT COUNT(*) FROM barang) AS total_produk,
  (SELECT COUNT(*) FROM barang WHERE stok <= stok_minimum) AS produk_stok_menipis,
  (SELECT IFNULL(SUM(total),0) FROM penjualan WHERE DATE(tgl_penjualan) = CURRENT_DATE()) AS penjualan_hari_ini,
  (SELECT COUNT(*) FROM pelanggan) AS total_pelanggan;

-- =========================
-- Seed sample data (optional)
-- =========================
-- Example categories
INSERT IGNORE INTO kategori (kode_kategori, nama_kategori, keterangan)
VALUES ('K001','Kemeja','Kemeja pria'), ('K002','Celana','Celana panjang'), ('K003','Aksesoris','Topi & sabuk');

-- Example barang
INSERT IGNORE INTO barang (kode_barang,nama_barang,kode_kategori,ukuran,warna,harga,stok,stok_minimum,satuan)
VALUES
('B001','Kemeja Slim Fit','K001','M','Putih',150000,50,5,'pcs'),
('B002','Celana Chino','K002','L','Abu',175000,30,5,'pcs');

-- Example pelanggan
INSERT IGNORE INTO pelanggan (kode_pelanggan,nama_pelanggan,telepon,alamat,email)
VALUES ('P001','Budi Santoso','08123456789','Jl. Merdeka 1','budi@mail.test');

-- Example supplier
INSERT IGNORE INTO supplier (kode_supplier,nama_supplier,telepon,kota)
VALUES ('S001','PT. Fashion','021-555111','Jakarta');

-- Done