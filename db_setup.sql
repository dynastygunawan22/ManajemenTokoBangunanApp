-- File: db_setup.sql
-- Jalankan di phpMyAdmin > tab SQL > paste > klik Go

CREATE DATABASE IF NOT EXISTS db_tokoBangunan
  CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

USE db_tokoBangunan;

CREATE TABLE IF NOT EXISTS kategori (
    id_kategori   INT AUTO_INCREMENT PRIMARY KEY,
    nama_kategori VARCHAR(100) NOT NULL,
    satuan        VARCHAR(50)  NOT NULL
) ENGINE=InnoDB;

INSERT INTO kategori (nama_kategori, satuan) VALUES
('Semen',          'Sak'),
('Besi / Baja',    'Batang'),
('Cat',            'Kaleng'),
('Kayu / Triplek', 'Lembar'),
('Batako',         'Buah'),
('Pipa',           'Batang');

CREATE TABLE IF NOT EXISTS barang (
    id_barang    INT AUTO_INCREMENT PRIMARY KEY,
    kode_barang  VARCHAR(20)   UNIQUE NOT NULL,
    nama_barang  VARCHAR(150)  NOT NULL,
    id_kategori  INT           NOT NULL,
    stok         INT           NOT NULL DEFAULT 0,
    stok_minimum INT           NOT NULL DEFAULT 5,
    harga_beli   DECIMAL(15,2) NOT NULL DEFAULT 0,
    harga_jual   DECIMAL(15,2) NOT NULL DEFAULT 0,
    FOREIGN KEY (id_kategori) REFERENCES kategori(id_kategori)
) ENGINE=InnoDB;

INSERT INTO barang (kode_barang, nama_barang, id_kategori, stok, stok_minimum, harga_beli, harga_jual) VALUES
('SMN-001', 'Semen Tiga Roda 40kg',  1,  50, 10,  55000,  62000),
('SMN-002', 'Semen Gresik 50kg',     1,  30, 10,  68000,  75000),
('BSI-001', 'Besi Beton 10mm',       2, 100, 20,  85000,  95000),
('BSI-002', 'Besi Beton 8mm',        2,   8, 20,  65000,  75000),
('CAT-001', 'Cat Tembok Dulux 5L',   3,  25,  5, 185000, 210000),
('CAT-002', 'Cat Kayu Avian 1L',     3,   3,  5,  45000,  55000),
('KYU-001', 'Triplek 9mm 122x244',   4,  60, 10,  95000, 115000),
('BTK-001', 'Batako Press 10x20x40', 5, 500, 50,   2500,   3200),
('PPA-001', 'Pipa PVC 4 inch',       6,   0, 15,  35000,  45000),
('PPA-002', 'Pipa PVC 2 inch',       6,  70, 15,  18000,  25000);

CREATE TABLE IF NOT EXISTS transaksi (
    id_transaksi    INT AUTO_INCREMENT PRIMARY KEY,
    no_transaksi    VARCHAR(30)   UNIQUE NOT NULL,
    jenis_transaksi ENUM('MASUK','KELUAR') NOT NULL,
    id_barang       INT           NOT NULL,
    jumlah          INT           NOT NULL,
    harga_satuan    DECIMAL(15,2) NOT NULL,
    total           DECIMAL(15,2) NOT NULL,
    keterangan      VARCHAR(255),
    tanggal         DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_barang) REFERENCES barang(id_barang)
) ENGINE=InnoDB;

INSERT INTO transaksi (no_transaksi, jenis_transaksi, id_barang, jumlah, harga_satuan, total, keterangan, tanggal) VALUES
('MSK-20250301-001', 'MASUK',  1, 20, 55000, 1100000, 'Supplier Aneka Bangunan', DATE_SUB(NOW(), INTERVAL 10 DAY)),
('KLR-20250302-001', 'KELUAR', 1,  5, 62000,  310000, 'Pelanggan Budi',          DATE_SUB(NOW(), INTERVAL 9 DAY)),
('MSK-20250303-001', 'MASUK',  3, 50, 85000, 4250000, 'Supplier Logam Jaya',     DATE_SUB(NOW(), INTERVAL 7 DAY)),
('KLR-20250304-001', 'KELUAR', 5,  3,210000,  630000, 'Proyek Pak Hendra',       DATE_SUB(NOW(), INTERVAL 5 DAY)),
('MSK-20250305-001', 'MASUK',  8,200,  2500,  500000, 'Supplier Batako Maju',    DATE_SUB(NOW(), INTERVAL 3 DAY)),
('KLR-20250306-001', 'KELUAR', 7, 10,115000, 1150000, 'CV Maju Jaya',            DATE_SUB(NOW(), INTERVAL 1 DAY)),
('MSK-20250307-001', 'MASUK', 10, 30, 18000,  540000, 'Supplier Pipa Nusantara', NOW());
