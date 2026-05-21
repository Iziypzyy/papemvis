-- Hapus kolom stok_minimum dari tabel barang dan perbarui view yang bergantung pada kolom tersebut.
-- Jalankan di database db_toko (MySQL) sebagai user yang punya hak ALTER / DROP / CREATE VIEW.

USE `db_toko`;

-- 1) Hapus kolom stok_minimum jika ada
ALTER TABLE `barang`
  DROP COLUMN IF EXISTS `stok_minimum`;

-- 2) Perbarui view v_stok_barang (tidak lagi menggunakan stok_minimum).
DROP VIEW IF EXISTS `v_stok_barang`;
CREATE VIEW `v_stok_barang` AS
SELECT
  b.kode_barang,
  b.nama_barang,
  b.stok,
  IFNULL(b.satuan, 'pcs') AS satuan,
  -- Status: jadikan "MENIPIS" bila stok = 0, lainya "AMAN"
  CASE WHEN b.stok <= 0 THEN 'MENIPIS' ELSE 'AMAN' END AS status_stok
FROM barang b;

-- 3) Perbarui view v_dashboard agar tidak mengacu pada stok_minimum.
DROP VIEW IF EXISTS `v_dashboard`;
CREATE VIEW `v_dashboard` AS
SELECT
  (SELECT COUNT(*) FROM barang) AS total_produk,
  -- Anggap menipis = stok = 0 (ubah kalau mau definisi lain)
  (SELECT COUNT(*) FROM barang WHERE stok <= 0) AS produk_stok_menipis,
  (SELECT IFNULL(SUM(total),0) FROM penjualan WHERE DATE(tgl_penjualan) = CURRENT_DATE()) AS penjualan_hari_ini,
  (SELECT COUNT(*) FROM pelanggan) AS total_pelanggan;