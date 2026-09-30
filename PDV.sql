-- Tipos/categorias de cliente.
CREATE TABLE IF NOT EXISTS `tipocliente` (
	`id` int AUTO_INCREMENT NOT NULL,
	`descricao` varchar(100) NOT NULL,
	PRIMARY KEY (`id`)
) COMMENT='Tipos/categorias de cliente.';
-- Cadastro de clientes (com login/senha).
CREATE TABLE IF NOT EXISTS `cliente` (
	`id` int AUTO_INCREMENT NOT NULL,
	`nome` varchar(100) NOT NULL,
	`email` varchar(100) NOT NULL UNIQUE,
	`telefone` varchar(15),
	`cpf` varchar(11),
	`datanascimento` date,
	`login` varchar(20) NOT NULL UNIQUE,
	`senha` varchar(50) NOT NULL,
	`datacadastro` datetime DEFAULT 'NULL',
	`dataultimoacesso` datetime DEFAULT 'NULL',
	`id_tipocliente` int,
	PRIMARY KEY (`id`)
) COMMENT='Cadastro de clientes (com login/senha).';
-- Cadastro de fornecedores.
CREATE TABLE IF NOT EXISTS `fornecedores` (
	`id_fornecedor` int AUTO_INCREMENT NOT NULL,
	`nome` varchar(100) NOT NULL,
	`cnpj` varchar(18),
	`telefone` varchar(20),
	`email` varchar(100),
	PRIMARY KEY (`id_fornecedor`)
) COMMENT='Cadastro de fornecedores.';
-- Cadastro de funcionários.
CREATE TABLE IF NOT EXISTS `funcionarios` (
	`id_funcionario` int AUTO_INCREMENT NOT NULL,
	`nome` varchar(100) NOT NULL,
	`cpf` varchar(14),
	`telefone` varchar(20),
	`cargo` varchar(50),
	`salario` decimal(10,2),
	PRIMARY KEY (`id_funcionario`)
) COMMENT='Cadastro de funcionários.';
-- Produtos do estoque/vendas.
CREATE TABLE IF NOT EXISTS `produtos` (
	`id_produto` int AUTO_INCREMENT NOT NULL,
	`fornecedor_id` int,
	`ncm` varchar(100),
	`descricao` varchar(200) NOT NULL,
	`preco_custo` decimal(10,2),
	`preco_venda` decimal(10,2) NOT NULL,
	`lote` int,
	`codigodebarras` int,
	`unidade_medida` int,
	`estoque` int NOT NULL DEFAULT 0,
	`estoque_minimo` int NOT NULL DEFAULT 0,
	`ativo` boolean NOT NULL DEFAULT true,
	PRIMARY KEY (`id_produto`)
) COMMENT='Produtos do estoque/vendas.';
-- Movimentações de estoque (entrada/saída/ajuste).
CREATE TABLE IF NOT EXISTS `estoque` (
	`id` int AUTO_INCREMENT NOT NULL,
	`produto_id` int NOT NULL,
	`tipo` enum NOT NULL DEFAULT '''ENTRADA''' COMMENT 'ENTRADA, SAIDA, AJUSTE',
	`quantidade` decimal(10,3) NOT NULL,
	`motivo` varchar(255),
	`data_movimentacao` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (`id`)
) COMMENT='Movimentações de estoque (entrada/saída/ajuste).';
-- Cabeçalho de vendas.
CREATE TABLE IF NOT EXISTS `vendas` (
	`id` int AUTO_INCREMENT NOT NULL,
	`cliente_id` int,
	`data_venda` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
	`valor_total` decimal(10,2) NOT NULL,
	`forma_pagamento` enum NOT NULL DEFAULT '''DINHEIRO''' COMMENT 'DINHEIRO, PIX, CARTAO_CREDITO, CARTAO_DEBITO, OUTRO',
	`status` enum NOT NULL DEFAULT '''PAGA''' COMMENT 'ABERTA, PAGA, CANCELADA',
	PRIMARY KEY (`id`)
) COMMENT='Cabeçalho de vendas.';
-- Contas a pagar/receber.
CREATE TABLE IF NOT EXISTS `contas` (
	`id` int AUTO_INCREMENT NOT NULL,
	`tipo` enum NOT NULL DEFAULT '''PENDENTE''' COMMENT 'PAGAR, RECEBER',
	`descricao` varchar(255) NOT NULL,
	`valor` decimal(10,2) NOT NULL,
	`data_vencimento` date NOT NULL,
	`data_pagamento` date DEFAULT 'NULL',
	`status` enum NOT NULL DEFAULT '''PENDENTE''' COMMENT 'PENDENTE, PAGA, ATRASADA, CANCELADA',
	`observacao` text,
	PRIMARY KEY (`id`)
) COMMENT='Contas a pagar/receber.';
ALTER TABLE `cliente` ADD CONSTRAINT `fk_cliente_tipocliente` FOREIGN KEY FOREIGN KEY (id_tipocliente) REFERENCES tipocliente(id);
ALTER TABLE `produtos` ADD CONSTRAINT `fk_produtos_fornecedores` FOREIGN KEY FOREIGN KEY (fornecedor_id) REFERENCES fornecedores(id_fornecedor);
ALTER TABLE `estoque` ADD CONSTRAINT `fk_estoque_produtos` FOREIGN KEY FOREIGN KEY (produto_id) REFERENCES produtos(id_produto);
ALTER TABLE `vendas` ADD CONSTRAINT `fk_vendas_cliente` FOREIGN KEY FOREIGN KEY (cliente_id) REFERENCES cliente(id);
CREATE INDEX `idx_cliente_id_tipocliente` USING BTREE ON `cliente` (`id_tipocliente`);
CREATE INDEX `idx_produtos_fornecedor_id` USING BTREE ON `produtos` (`fornecedor_id`);
CREATE INDEX `idx_estoque_produto_id` USING BTREE ON `estoque` (`produto_id`);
CREATE INDEX `idx_estoque_tipo_data` USING BTREE ON `estoque` (`tipo`, `data_movimentacao`);
CREATE INDEX `idx_vendas_cliente_id` USING BTREE ON `vendas` (`cliente_id`);
CREATE INDEX `idx_vendas_data` USING BTREE ON `vendas` (`data_venda`);
CREATE INDEX `idx_contas_status_venc` USING BTREE ON `contas` (`status`, `data_vencimento`);