-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 13-Set-2015 às 21:49
-- Versão do servidor: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `solidfy`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
`id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `endereco_pfisica`
--

CREATE TABLE IF NOT EXISTS `endereco_pfisica` (
`id` int(11) NOT NULL,
  `codigo` int(100) NOT NULL,
  `pais` varchar(100) NOT NULL,
  `uf` varchar(100) NOT NULL,
  `uf_regiao` varchar(100) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `cidade_regiao` varchar(100) NOT NULL,
  `bairro` varchar(100) NOT NULL,
  `logradouro` varchar(100) NOT NULL,
  `tipo_logradouro` varchar(100) NOT NULL,
  `numero` int(11) NOT NULL,
  `complemento` varchar(100) NOT NULL,
  `pontos_referencia` varchar(100) NOT NULL,
  `geo_localizacao` varchar(100) NOT NULL,
  `nome_propietario` varchar(100) NOT NULL,
  `melhor_horario` varchar(100) NOT NULL,
  `cadastrado_por` varchar(100) NOT NULL,
  `data_cadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

CREATE TABLE IF NOT EXISTS `fornecedor` (
`id` int(11) NOT NULL,
  `nome_fantasia` varchar(100) NOT NULL,
  `razao_social` varchar(100) NOT NULL,
  `cnpj` varchar(100) NOT NULL,
  `seguimento` varchar(100) NOT NULL,
  `tel_principal` varchar(100) NOT NULL,
  `tel_alternativo` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `webpage` varchar(100) NOT NULL,
  `endereco_codigo` int(11) NOT NULL,
  `representantenome` varchar(100) NOT NULL,
  `representantesexo` varchar(100) NOT NULL,
  `representantetel1` varchar(100) NOT NULL,
  `representantetel2` varchar(100) NOT NULL,
  `representanteemail` varchar(100) NOT NULL,
  `observacoes` varchar(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  `cadastrado_por` varchar(100) NOT NULL,
  `data-cadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `itemestoque`
--

CREATE TABLE IF NOT EXISTS `itemestoque` (
  `id` int(11) NOT NULL,
  `codigo` varchar(100) NOT NULL,
  `codigo_de_barras` varchar(100) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `detalhes` varchar(100) NOT NULL,
  `categoria` varchar(100) NOT NULL,
  `endereco_estoque` varchar(100) NOT NULL,
  `unidade_medida` varchar(100) NOT NULL,
  `quantidade` float NOT NULL,
  `quantidade_maxima` float NOT NULL,
  `quantidade_minima` float NOT NULL,
  `dimanssao_x` float NOT NULL,
  `dimessao_y` float NOT NULL,
  `dimessao_z` float NOT NULL,
  `peso` float NOT NULL,
  `jurus_icms` float NOT NULL,
  `jurus_ipi` float NOT NULL,
  `jurus_outros` float NOT NULL,
  `desconto` float NOT NULL,
  `valor_fornecedor` float NOT NULL,
  `valor_itegral` float NOT NULL,
  `valor_final` float NOT NULL,
  `fornecedor_principal` varchar(100) NOT NULL,
  `marca` varchar(100) NOT NULL,
  `modelo` varchar(100) NOT NULL,
  `lote` varchar(100) NOT NULL,
  `data_vencimento` datetime NOT NULL,
  `cadastrado_por` varchar(100) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` varchar(100) NOT NULL,
  `status_motivo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `itemestoquecategoria`
--

CREATE TABLE IF NOT EXISTS `itemestoquecategoria` (
`id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `cadastrado_por` varchar(100) NOT NULL,
  `data_cadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `itemestoquemodelo`
--

CREATE TABLE IF NOT EXISTS `itemestoquemodelo` (
`id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `marca` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `itemestoque_marca`
--

CREATE TABLE IF NOT EXISTS `itemestoque_marca` (
`id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `fornecedor_principal` varchar(100) NOT NULL,
  `cadastrado_por` varchar(100) NOT NULL,
  `data_cadastro` datetime NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `itemestoque_marca`
--

INSERT INTO `itemestoque_marca` (`id`, `nome`, `fornecedor_principal`, `cadastrado_por`, `data_cadastro`) VALUES
(1, 'TesteSec 2', 'NULL', 'danilo', '2015-09-13 16:07:07'),
(2, 'Fooo Tty', 'NULL', 'danilo', '2015-09-13 15:53:39');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categoria`
--
ALTER TABLE `categoria`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `endereco_pfisica`
--
ALTER TABLE `endereco_pfisica`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `fornecedor`
--
ALTER TABLE `fornecedor`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `itemestoque`
--
ALTER TABLE `itemestoque`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `itemestoquecategoria`
--
ALTER TABLE `itemestoquecategoria`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `itemestoquemodelo`
--
ALTER TABLE `itemestoquemodelo`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `itemestoque_marca`
--
ALTER TABLE `itemestoque_marca`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categoria`
--
ALTER TABLE `categoria`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `endereco_pfisica`
--
ALTER TABLE `endereco_pfisica`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `fornecedor`
--
ALTER TABLE `fornecedor`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `itemestoquecategoria`
--
ALTER TABLE `itemestoquecategoria`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `itemestoquemodelo`
--
ALTER TABLE `itemestoquemodelo`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `itemestoque_marca`
--
ALTER TABLE `itemestoque_marca`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
