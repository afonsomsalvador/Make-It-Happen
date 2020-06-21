-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Jun-2020 às 17:21
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.2.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `psi18_afonsosalvador`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `categorias`
--

CREATE TABLE `categorias` (
  `id_Categoria` int(11) NOT NULL,
  `nome` varchar(70) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `categorias`
--

INSERT INTO `categorias` (`id_Categoria`, `nome`) VALUES
(1, 'Vida Marinha'),
(2, 'Ensino'),
(3, 'Vida Terrestre');

-- --------------------------------------------------------

--
-- Estrutura da tabela `experiencia`
--

CREATE TABLE `experiencia` (
  `idExperiencia` int(11) NOT NULL,
  `tipo_experiencia` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `experiencia`
--

INSERT INTO `experiencia` (`idExperiencia`, `tipo_experiencia`) VALUES
(1, 'Com experiência'),
(2, 'Sem experiência');

-- --------------------------------------------------------

--
-- Estrutura da tabela `login`
--

CREATE TABLE `login` (
  `id_user` int(11) NOT NULL,
  `user` varchar(20) NOT NULL,
  `Password` varchar(8) NOT NULL,
  `nome` varchar(80) NOT NULL,
  `email` varchar(45) NOT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `Pais_idPais` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `login`
--

INSERT INTO `login` (`id_user`, `user`, `Password`, `nome`, `email`, `foto`, `Pais_idPais`) VALUES
(1, 'admin', 'admin', 'admin', 'admin@admin.pt', NULL, 3),
(22, 'boss', 'boss', 'Afonso Macedo Salvador', 'afonso.macedo1@gmail.com', '????\0JFIF\0\0\0\0\0\0\0??\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342??\0C			\r\r2!!22222222222222222222222222222222222222222222222222??\0?\"\0??\0\0\0\0\0\0\0\0\0\0\0\0\0\0??\0P\0	\0!1AQ\"aq2???#BR?', 5);

-- --------------------------------------------------------

--
-- Estrutura da tabela `noticias`
--

CREATE TABLE `noticias` (
  `idNoticias` int(11) NOT NULL,
  `Titulo` varchar(45) NOT NULL,
  `Corpo` varchar(420) NOT NULL,
  `Imagem` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `noticias`
--

INSERT INTO `noticias` (`idNoticias`, `Titulo`, `Corpo`, `Imagem`) VALUES
(19, 'Make It Happen', 'A nova aplicação Make It Happen está concluida e pronta para transmitir aos seus utilizadores uma informação credivel e organizada sobre futuros projetos de voluntariado existentes em todo o mundo!!\r\n', 'b60ab72f-3ded-473a-8f1f-0d76a12f3344.jpg'),
(21, 'Novo voluntariado na África do Sul ', 'Pela primeira vez temos um voluntariado na África do Sul. \r\nEste voluntariado permite te nadar com tubarões brancos e alimenta-los de forma a que a espécie nao se extinga.', '39a4a3f0-63a2-486e-996b-401dc191c24f.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `organizacao`
--

CREATE TABLE `organizacao` (
  `idOrganizacao` int(11) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `responsavel_vol` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `organizacao`
--

INSERT INTO `organizacao` (`idOrganizacao`, `nome`, `email`, `responsavel_vol`) VALUES
(1, 'Global Volunteers', ' info@globalvolunteers.org', 'ex'),
(2, 'Volunteering Solutions', 'info@volunteeringsolutions.com', 'ze da esquina');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pais`
--

CREATE TABLE `pais` (
  `idPais` int(11) NOT NULL,
  `nome` varchar(15) NOT NULL,
  `imagem` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `pais`
--

INSERT INTO `pais` (`idPais`, `nome`, `imagem`) VALUES
(3, 'Espanha', '8f1147dd-8d70-47f2-a122-f0ff11c7e754.jpg'),
(5, 'Portugal', '3c3c1ff1-317e-43d7-8b3c-cd99f3681692.jpg'),
(6, 'Tailândia', 'fc25bb92-cbd9-4aa2-a626-59cd7ce259b8.jpg'),
(7, 'Vietname', '79dc79e0-e559-41a7-a04f-eb3e5aca47d5.jpg'),
(8, 'Nepal', 'e5e0615b-05ce-4a32-b326-6f860266992d.jpg'),
(9, 'França', '73e43dec-fe96-419d-9759-e32094283547.jpg'),
(10, 'Alemanha', 'cec0b59a-2143-4959-8cf8-25f6319945f0.jpg'),
(11, 'Brasil', '6499a1e1-3293-4ad8-ab6d-c28fe9bdbb8f.jpg'),
(12, 'África do Sul', '8ea32e9d-5a5d-4bf3-bdfb-1d33686259b3.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `voluntariado`
--

CREATE TABLE `voluntariado` (
  `idVoluntariado` int(11) NOT NULL,
  `Descricao` varchar(650) NOT NULL,
  `Categorias_id_Categoria` int(11) NOT NULL,
  `Organizacao_idOrganizacao` int(11) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `imagem` varchar(255) DEFAULT NULL,
  `Experiencia_idExperiencia` int(11) NOT NULL,
  `Pais_idPais` int(11) NOT NULL,
  `Idade` varchar(45) NOT NULL,
  `Lingua` varchar(45) NOT NULL,
  `Escolaridade` varchar(45) NOT NULL,
  `data` date NOT NULL,
  `duracao` varchar(30) NOT NULL,
  `alojamento` varchar(75) NOT NULL,
  `alimentacao` varchar(75) NOT NULL,
  `transfers` varchar(75) NOT NULL,
  `seguro` varchar(75) NOT NULL,
  `acompanhamento` varchar(80) DEFAULT NULL,
  `localidade` varchar(60) NOT NULL,
  `adicional` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `voluntariado`
--

INSERT INTO `voluntariado` (`idVoluntariado`, `Descricao`, `Categorias_id_Categoria`, `Organizacao_idOrganizacao`, `nome`, `imagem`, `Experiencia_idExperiencia`, `Pais_idPais`, `Idade`, `Lingua`, `Escolaridade`, `data`, `duracao`, `alojamento`, `alimentacao`, `transfers`, `seguro`, `acompanhamento`, `localidade`, `adicional`) VALUES
(21, 'A proposta é ser voluntário na Tailândia num projeto com elefantes resgatados do trabalho agrícola e extração de madeira. Os animais vivem na floresta junto da comunidade local que protege os elefantes e os insere no seu habitat natural.\r\nComo voluntário vai caminhar, nadar e dar banho aos elefantes, ajudar a população local nas rotinas diárias, a preparar os alimentos e a alimentar os elefantes. Contribui para a proteção da espécie e observa o quanto estes animais são incrivelmente inteligentes. Faz ainda diversas atividades como rafting, trekking, caiaque, canoagem, nadar em cascatas, admirar paisagens deslumbrantes entre outros...', 3, 1, 'Elefantes na Tailândia', '8b653d89-d477-4ead-ab74-d3ec3a71a21e.jpg', 2, 6, 'Maiores de 18 anos.', 'Nível de inglês: básico ou superior.', 'Todos os anos de escolaridade.', '2020-07-30', '1 a 2 semanas.', 'Incluído durante o programa.', 'Incluído durante o programa.', 'Incluído na chegada.', 'Sem seguro incluido.', 'A equipa local está à sua espera no aeroporto para o acompanhar até ao alojament', 'Umphang', 'Sem contéudo adicional.'),
(22, ' Como voluntário ajuda os professores nas várias atividades do plano académico, como ensinar inglês, matemática, informática, jogos criativos, música e, ainda, vai apoiar os alunos nos trabalhos escolares e os professores na preparação das lições.\r\n\r\nPara participar não precisa de ter experiência a ensinar, pois a equipa vai explicar tudo sobre o plano educacional, as atividades do dia a dia e fornecer o material didático necessário para que o seu tempo no projeto tenha o maior impacto.', 2, 2, 'Ensino a crianças no Nepal', '87da1f96-0c40-430c-9236-6a27752d8d39.jpg', 2, 8, 'Mais de16 anos.', 'Nível de inglês: intermédio ou superior.', 'Todos os anos de escolaridade', '2020-07-04', '2 a 12 semanas.', 'Incluído durante o programa.', 'Incluído durante o programa.', 'Incluídos na chegada e regresso.', 'Seguro garantido.', 'Acompanhamento no aeroporto pela equipa local.', 'Kathmandu', 'Sem contéudo adicional.'),
(23, ' Como voluntário ajuda os professores nas várias atividades do plano académico, como ensinar inglês, matemática, informática, jogos criativos, música e, ainda, vai apoiar os alunos nos trabalhos escolares e os professores na preparação das lições.\r\nPara participar não precisa de ter experiência a ensinar, pois a equipa vai explicar tudo sobre o plano educacional, as atividades do dia a dia e fornecer o material didático necessário para que o seu tempo no projeto tenha o maior impacto.', 2, 1, 'Ensino a crianças no Vietname', '28017520-5a82-4fb5-bc05-6080f041453d.jpg', 2, 7, 'Mais de 16 anos.', 'Nível de inglês: intermédio ou superior.', 'Todos os anos de escolaridade', '2020-11-17', '2 a 12 semanas.', 'Incluído durante o programa.', 'Incluído durante o programa.', 'Incluídos na chegada e regresso.', 'Seguro é garantido.', 'Acompanhamento da equipa local.', 'Ho Chi Minh', 'Sem contéudo adicional.'),
(24, 'Como voluntário vai estar envolvido em várias tarefas e ajudar a equipa nas operações de mergulho e manutenção dos recursos, nas embarcações de ecoturismo, na educação dos turistas, na conservação dos tubarões e da vida marinha, entre muitas outras.\r\n\r\nMergulhe com os grandes tubarões brancos e observe-os no seu habitat natural, veja baleias, golfinhos, pinguins e focas, aprenda sobre conservação dos oceanos e das espécies marinhas, participe excursões e atividades para aproveitar a viagem ao máximo.', 1, 2, 'Tubarões na África do Sul', '338b5ddd-d234-4bfe-a4a1-e39e2f315dc3.jpg', 2, 12, 'Maiores de 18 anos.', 'Nível de inglês: intermédio ou superior.', 'Todos os anos de escolaridade.', '2020-07-03', '2 a 12 semanas.', 'Incluído durante o programa.', 'Incluído pequeno almoço e almoço.', 'Incluídos na chegada e regresso.', 'Seguro é garantido.', 'Acompanhamento pela equipa local.', 'Gansbaai', 'Saber nadar: obrigatório.');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id_Categoria`);

--
-- Índices para tabela `experiencia`
--
ALTER TABLE `experiencia`
  ADD PRIMARY KEY (`idExperiencia`);

--
-- Índices para tabela `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id_user`,`Pais_idPais`),
  ADD UNIQUE KEY `user` (`user`),
  ADD KEY `fk_Login_Pais1_idx` (`Pais_idPais`);

--
-- Índices para tabela `noticias`
--
ALTER TABLE `noticias`
  ADD PRIMARY KEY (`idNoticias`);

--
-- Índices para tabela `organizacao`
--
ALTER TABLE `organizacao`
  ADD PRIMARY KEY (`idOrganizacao`);

--
-- Índices para tabela `pais`
--
ALTER TABLE `pais`
  ADD PRIMARY KEY (`idPais`);

--
-- Índices para tabela `voluntariado`
--
ALTER TABLE `voluntariado`
  ADD PRIMARY KEY (`idVoluntariado`,`Categorias_id_Categoria`,`Organizacao_idOrganizacao`,`Experiencia_idExperiencia`,`Pais_idPais`),
  ADD KEY `fk_Voluntariado_Categorias1_idx` (`Categorias_id_Categoria`),
  ADD KEY `fk_Voluntariado_Organizacao1_idx` (`Organizacao_idOrganizacao`),
  ADD KEY `fk_Voluntariado_Experiencia1_idx` (`Experiencia_idExperiencia`),
  ADD KEY `fk_Voluntariado_Pais1_idx` (`Pais_idPais`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id_Categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `experiencia`
--
ALTER TABLE `experiencia`
  MODIFY `idExperiencia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `login`
--
ALTER TABLE `login`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de tabela `noticias`
--
ALTER TABLE `noticias`
  MODIFY `idNoticias` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT de tabela `organizacao`
--
ALTER TABLE `organizacao`
  MODIFY `idOrganizacao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `pais`
--
ALTER TABLE `pais`
  MODIFY `idPais` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `voluntariado`
--
ALTER TABLE `voluntariado`
  MODIFY `idVoluntariado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `fk_Login_Pais1` FOREIGN KEY (`Pais_idPais`) REFERENCES `pais` (`idPais`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `voluntariado`
--
ALTER TABLE `voluntariado`
  ADD CONSTRAINT `fk_Voluntariado_Categorias1` FOREIGN KEY (`Categorias_id_Categoria`) REFERENCES `categorias` (`id_Categoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Voluntariado_Experiencia1` FOREIGN KEY (`Experiencia_idExperiencia`) REFERENCES `experiencia` (`idExperiencia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Voluntariado_Organizacao1` FOREIGN KEY (`Organizacao_idOrganizacao`) REFERENCES `organizacao` (`idOrganizacao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Voluntariado_Pais1` FOREIGN KEY (`Pais_idPais`) REFERENCES `pais` (`idPais`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
