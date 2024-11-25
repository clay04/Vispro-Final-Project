-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2024 at 11:57 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_klinik`
--

-- --------------------------------------------------------

--
-- Table structure for table `resep_obat`
--

CREATE TABLE `resep_obat` (
  `id_resep` int(11) NOT NULL,
  `id_obat` int(11) NOT NULL,
  `id_pasien` int(11) NOT NULL,
  `dosis` varchar(50) NOT NULL,
  `cara_pakai` varchar(100) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `keterangan` text DEFAULT NULL,
  `id_rekam_medis` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `resep_obat`
--

INSERT INTO `resep_obat` (`id_resep`, `id_obat`, `id_pasien`, `dosis`, `cara_pakai`, `jumlah`, `keterangan`, `id_rekam_medis`) VALUES
(1, 1, 1, 'abc', 'abc', 0, 'abc', 3),
(2, 2, 7, '3 kali sehari', 'di kunyah sebelum makan', 12, 'Habiskan dalam 4 hari', 4),
(3, 1, 4, '3 kali satu hari', 'Minum setelah makan', 12, 'Minum sampai 3 hari kedepan kalau tidak ada perubahan habiskan obat', 5),
(6, 1, 8, '3 kali sehari', 'minum sesudah makan', 9, 'minum sampai habis', 6),
(7, 1, 9, '3 kali sehari', 'Minum Sesudahh makan', 6, 'Minum sampai habis', 6),
(8, 2, 9, '2 kali sehari', 'minum sebelum makan', 4, 'Habiskan', 6);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_apoteker`
--

CREATE TABLE `tbl_apoteker` (
  `id_apoteker` int(11) NOT NULL,
  `username_apoteker` varchar(25) NOT NULL,
  `nama_apoteker` varchar(31) NOT NULL,
  `alamat` varchar(225) NOT NULL,
  `tanggal_bekerja` date NOT NULL,
  `no_telepon` int(16) NOT NULL,
  `email` varchar(25) NOT NULL,
  `password` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_apoteker`
--

INSERT INTO `tbl_apoteker` (`id_apoteker`, `username_apoteker`, `nama_apoteker`, `alamat`, `tanggal_bekerja`, `no_telepon`, `email`, `password`) VALUES
(1, 'apoteker', 'Apoteker', 'Universitas Klabat', '2024-11-01', 822678032, 'apoteker@gmail.com', 'apoteker');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_dokter`
--

CREATE TABLE `tbl_dokter` (
  `id_dokter` int(11) NOT NULL,
  `username_dokter` varchar(25) NOT NULL,
  `nama_dokter` varchar(31) NOT NULL,
  `alamat` varchar(225) NOT NULL,
  `tanggal_bekerja` date DEFAULT NULL,
  `no_telepon` int(17) NOT NULL,
  `email` varchar(31) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_dokter`
--

INSERT INTO `tbl_dokter` (`id_dokter`, `username_dokter`, `nama_dokter`, `alamat`, `tanggal_bekerja`, `no_telepon`, `email`, `password`) VALUES
(1, 'dokter', 'Dokter', 'Universitas Klabat', '2024-11-06', 822, 'claymangeber04@gmail.com', 'dokter'),
(2, 'clay', 'Clay Mangeber', 'Universitas Klabat', '2020-06-10', 2147483647, 'aikendebora11@gmail.com', 'clay04');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_login_history`
--

CREATE TABLE `tbl_login_history` (
  `id` int(11) NOT NULL,
  `id_user` int(11) DEFAULT NULL,
  `id_dokter` int(11) DEFAULT NULL,
  `id_staff` int(11) DEFAULT NULL,
  `jenis_user` enum('admin','dokter','staff') DEFAULT NULL,
  `waktu_login` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_obat`
--

CREATE TABLE `tbl_obat` (
  `id_obat` int(11) NOT NULL,
  `nama_obat` varchar(55) NOT NULL,
  `kategori` varchar(55) NOT NULL,
  `tanggal_kadaluarsa` date NOT NULL,
  `harga_obat` decimal(9,2) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `jenis_obat` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_obat`
--

INSERT INTO `tbl_obat` (`id_obat`, `nama_obat`, `kategori`, `tanggal_kadaluarsa`, `harga_obat`, `jumlah`, `jenis_obat`) VALUES
(1, 'Paracetamol', 'B', '2025-05-21', 8000.00, 100, 'analgesic dan antipiretik'),
(2, 'Amoxilin', 'Antibiotik', '2025-05-21', 15000.00, 100, 'analgesic dan antipiretik');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pasien`
--

CREATE TABLE `tbl_pasien` (
  `id_pasien` int(11) NOT NULL,
  `nama_pasien` varchar(31) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `no_telepon` varchar(20) NOT NULL,
  `gender` enum('Laki-laki','Perempuan') NOT NULL,
  `riwayat_penyakit` text NOT NULL,
  `keluhan` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pasien`
--

INSERT INTO `tbl_pasien` (`id_pasien`, `nama_pasien`, `tanggal_lahir`, `alamat`, `no_telepon`, `gender`, `riwayat_penyakit`, `keluhan`) VALUES
(1, 'Clay Mangeber', '2004-03-04', 'Desa Kuyangan satu, Kec. Tombatu Utara, Kabupaten Minahasa Tengga, Provinsi Sulawesi Utara', '0822678032', 'Laki-laki', 'Sakit Jantung', 'Demam di sertai keringat dingin'),
(4, 'Clay Aiken', '2004-03-04', 'Desa Kuyanga Satu, Jaga 1', '082267803232', 'Laki-laki', 'Ginjal', ''),
(5, 'Debe', '2023-11-05', 'Aermadidi Bawah', '082252867733', 'Perempuan', 'Gula tinggi', ''),
(6, 'Debora', '2003-09-24', 'Universitas Klabat', '0822251867733', 'Perempuan', 'Darah Tinggi', ''),
(7, 'Angeli', '2024-11-12', 'Kupang, NTT', '0877907890', 'Perempuan', 'Jantung Kronis', ''),
(8, 'Junior', '2000-02-10', 'Universitas Klabat', '0823456789034', 'Laki-laki', 'Asam Urat', 'Demam tapi badan kerasa dingin'),
(9, 'Lovenia', '2003-09-24', 'Universitas Klabat', '082251867733', 'Perempuan', 'Tidak ada', 'Sakit Kepala');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pembayaran`
--

CREATE TABLE `tbl_pembayaran` (
  `id_pembayaran` int(11) NOT NULL,
  `id_pendaftaran` int(11) DEFAULT NULL,
  `tanggal_pembayaran` date DEFAULT curdate(),
  `jumlah` decimal(10,2) NOT NULL,
  `metode_pembayaran` enum('tunai','kartu','transfer') NOT NULL,
  `status_pembayaran` enum('belum_dibayar','sudah_dibayar','menunggu_konfirmasi') DEFAULT 'belum_dibayar'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pembayaran`
--

INSERT INTO `tbl_pembayaran` (`id_pembayaran`, `id_pendaftaran`, `tanggal_pembayaran`, `jumlah`, `metode_pembayaran`, `status_pembayaran`) VALUES
(1, 4, '2024-11-13', 100000.00, 'tunai', 'belum_dibayar'),
(2, 4, '2024-11-18', 100000.00, 'tunai', 'sudah_dibayar'),
(3, 7, '2024-11-25', 208000.00, 'tunai', 'sudah_dibayar');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pendaftaran`
--

CREATE TABLE `tbl_pendaftaran` (
  `id_pendaftaran` int(11) NOT NULL,
  `id_pasien` int(11) DEFAULT NULL,
  `id_dokter` int(11) DEFAULT NULL,
  `tanggal_daftar` date NOT NULL,
  `status` enum('terdaftar','selesai','batal') DEFAULT 'terdaftar'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pendaftaran`
--

INSERT INTO `tbl_pendaftaran` (`id_pendaftaran`, `id_pasien`, `id_dokter`, `tanggal_daftar`, `status`) VALUES
(1, 4, 2, '2024-11-10', 'selesai'),
(2, 5, 2, '2024-11-11', 'terdaftar'),
(3, 6, 2, '2024-11-12', 'terdaftar'),
(4, 1, 2, '2024-11-07', 'selesai'),
(5, 7, 2, '2024-11-12', 'selesai'),
(6, 8, 2, '2024-11-25', 'terdaftar'),
(7, 9, 2, '2024-11-25', 'terdaftar');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_perawat`
--

CREATE TABLE `tbl_perawat` (
  `id_perawat` int(11) NOT NULL,
  `username_perawat` varchar(25) NOT NULL,
  `nama_perawat` varchar(31) NOT NULL,
  `alamat` varchar(225) NOT NULL,
  `tanggal_bekerja` date NOT NULL,
  `no_telepon` int(11) NOT NULL,
  `email` varchar(25) NOT NULL,
  `password` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_perawat`
--

INSERT INTO `tbl_perawat` (`id_perawat`, `username_perawat`, `nama_perawat`, `alamat`, `tanggal_bekerja`, `no_telepon`, `email`, `password`) VALUES
(1, 'perawat', 'Perawat', 'Universitas Klabat', '2024-11-01', 822798734, 'perawat@gmail.com', 'perawat');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_rekam_medis`
--

CREATE TABLE `tbl_rekam_medis` (
  `id_rekam_medis` int(11) NOT NULL,
  `id_pasien` int(11) DEFAULT NULL,
  `tanggal_periksa` date NOT NULL,
  `diagnosa` varchar(255) NOT NULL,
  `catatan_tambahan` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_rekam_medis`
--

INSERT INTO `tbl_rekam_medis` (`id_rekam_medis`, `id_pasien`, `tanggal_periksa`, `diagnosa`, `catatan_tambahan`) VALUES
(3, 1, '2024-11-11', 'okok', 'abc'),
(4, 7, '2024-11-12', 'Terlalu lama sendiri', 'bacarii joo'),
(5, 4, '2024-11-13', 'Panas Tinggi', 'Ada bengkak di bagian tangan'),
(6, 8, '2024-11-25', 'Malaria', 'Banyak istirahat dan minum air putih');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_staff`
--

CREATE TABLE `tbl_staff` (
  `id_staff` int(11) NOT NULL,
  `username` varchar(25) NOT NULL,
  `nama_lengkap` varchar(31) NOT NULL,
  `alamat` varchar(250) NOT NULL,
  `tanggal_bekerja` date DEFAULT NULL,
  `nomor_telepon` int(17) NOT NULL,
  `email` varchar(55) NOT NULL,
  `password` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_staff`
--

INSERT INTO `tbl_staff` (`id_staff`, `username`, `nama_lengkap`, `alamat`, `tanggal_bekerja`, `nomor_telepon`, `email`, `password`) VALUES
(1, 'aiken', 'Aiken Jr', 'Universitas Klabat', '2024-08-14', 8546345, 'aiken@gmail.com', 'aiken04');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `nama_lengkap` varchar(31) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`id_user`, `username`, `nama_lengkap`, `password`) VALUES
(3, 'admin', 'Administrator', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `resep_obat`
--
ALTER TABLE `resep_obat`
  ADD PRIMARY KEY (`id_resep`),
  ADD KEY `id_obat` (`id_obat`),
  ADD KEY `resep_obat_ibfk_2` (`id_pasien`),
  ADD KEY `fk_rekam_medis` (`id_rekam_medis`);

--
-- Indexes for table `tbl_apoteker`
--
ALTER TABLE `tbl_apoteker`
  ADD PRIMARY KEY (`id_apoteker`);

--
-- Indexes for table `tbl_dokter`
--
ALTER TABLE `tbl_dokter`
  ADD PRIMARY KEY (`id_dokter`);

--
-- Indexes for table `tbl_login_history`
--
ALTER TABLE `tbl_login_history`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`),
  ADD KEY `id_dokter` (`id_dokter`),
  ADD KEY `id_staff` (`id_staff`);

--
-- Indexes for table `tbl_obat`
--
ALTER TABLE `tbl_obat`
  ADD PRIMARY KEY (`id_obat`);

--
-- Indexes for table `tbl_pasien`
--
ALTER TABLE `tbl_pasien`
  ADD PRIMARY KEY (`id_pasien`);

--
-- Indexes for table `tbl_pembayaran`
--
ALTER TABLE `tbl_pembayaran`
  ADD PRIMARY KEY (`id_pembayaran`),
  ADD KEY `id_pendaftaran` (`id_pendaftaran`);

--
-- Indexes for table `tbl_pendaftaran`
--
ALTER TABLE `tbl_pendaftaran`
  ADD PRIMARY KEY (`id_pendaftaran`),
  ADD KEY `id_pasien` (`id_pasien`),
  ADD KEY `id_dokter` (`id_dokter`);

--
-- Indexes for table `tbl_perawat`
--
ALTER TABLE `tbl_perawat`
  ADD PRIMARY KEY (`id_perawat`);

--
-- Indexes for table `tbl_rekam_medis`
--
ALTER TABLE `tbl_rekam_medis`
  ADD PRIMARY KEY (`id_rekam_medis`),
  ADD KEY `id_pasien` (`id_pasien`);

--
-- Indexes for table `tbl_staff`
--
ALTER TABLE `tbl_staff`
  ADD PRIMARY KEY (`id_staff`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `resep_obat`
--
ALTER TABLE `resep_obat`
  MODIFY `id_resep` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbl_apoteker`
--
ALTER TABLE `tbl_apoteker`
  MODIFY `id_apoteker` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_dokter`
--
ALTER TABLE `tbl_dokter`
  MODIFY `id_dokter` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_login_history`
--
ALTER TABLE `tbl_login_history`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_obat`
--
ALTER TABLE `tbl_obat`
  MODIFY `id_obat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_pasien`
--
ALTER TABLE `tbl_pasien`
  MODIFY `id_pasien` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbl_pembayaran`
--
ALTER TABLE `tbl_pembayaran`
  MODIFY `id_pembayaran` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_pendaftaran`
--
ALTER TABLE `tbl_pendaftaran`
  MODIFY `id_pendaftaran` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbl_perawat`
--
ALTER TABLE `tbl_perawat`
  MODIFY `id_perawat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_rekam_medis`
--
ALTER TABLE `tbl_rekam_medis`
  MODIFY `id_rekam_medis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_staff`
--
ALTER TABLE `tbl_staff`
  MODIFY `id_staff` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `resep_obat`
--
ALTER TABLE `resep_obat`
  ADD CONSTRAINT `fk_id_obat` FOREIGN KEY (`id_obat`) REFERENCES `tbl_obat` (`id_obat`),
  ADD CONSTRAINT `fk_id_pasien` FOREIGN KEY (`id_pasien`) REFERENCES `tbl_pasien` (`id_pasien`),
  ADD CONSTRAINT `fk_rekam_medis` FOREIGN KEY (`id_rekam_medis`) REFERENCES `tbl_rekam_medis` (`id_Rekam_medis`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_login_history`
--
ALTER TABLE `tbl_login_history`
  ADD CONSTRAINT `tbl_login_history_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `tbl_user` (`id_user`) ON DELETE SET NULL,
  ADD CONSTRAINT `tbl_login_history_ibfk_2` FOREIGN KEY (`id_dokter`) REFERENCES `tbl_dokter` (`id_dokter`) ON DELETE SET NULL,
  ADD CONSTRAINT `tbl_login_history_ibfk_3` FOREIGN KEY (`id_staff`) REFERENCES `tbl_staff` (`id_staff`) ON DELETE SET NULL;

--
-- Constraints for table `tbl_pembayaran`
--
ALTER TABLE `tbl_pembayaran`
  ADD CONSTRAINT `tbl_pembayaran_ibfk_1` FOREIGN KEY (`id_pendaftaran`) REFERENCES `tbl_pendaftaran` (`id_pendaftaran`);

--
-- Constraints for table `tbl_pendaftaran`
--
ALTER TABLE `tbl_pendaftaran`
  ADD CONSTRAINT `tbl_pendaftaran_ibfk_1` FOREIGN KEY (`id_pasien`) REFERENCES `tbl_pasien` (`id_pasien`),
  ADD CONSTRAINT `tbl_pendaftaran_ibfk_2` FOREIGN KEY (`id_dokter`) REFERENCES `tbl_dokter` (`id_dokter`);

--
-- Constraints for table `tbl_rekam_medis`
--
ALTER TABLE `tbl_rekam_medis`
  ADD CONSTRAINT `tbl_rekam_medis_ibfk_1` FOREIGN KEY (`id_pasien`) REFERENCES `tbl_pasien` (`id_pasien`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
