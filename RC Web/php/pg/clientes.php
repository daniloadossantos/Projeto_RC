<?php
session_start();

require('../db/db.php');
require('../cls/cliente.php');
$_SESSION["C"] = [];
$_SESSION["R"] = [];
$_SESSION["U"] = [];
$_SESSION["D"] = [];
$clientes = DB::getClientes();
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Clientes - RC Ar-condicionado</title>
    <link rel="stylesheet" href="../../css/global.css">
    <link rel="stylesheet" href="../../css/clientes.css">

    <link rel="shortcut icon" href="img/winter32.png" type="image/x-icon">
</head>
<body>
  <div>
    <section class="grid grid-template-row">
      <div class="item nav">
        <header class="header-nav">
          <h1>Bem-vindo, <span class="nome_func">nome</span>!</h1>
          <div class="btn_menu">
            <div class="btn_perfil"><a href=""><img src="./img/user-circle-svgrepo-com.svg" alt="foto do usuário" title="Perfil"></a></div>
            <div class="btn_logout"><a href="index.html"><img src="./img/logout-svgrepo-com.svg" alt="logout" title="Sair"></a></div>
          </div>
        </header>
      </div>
      <div class="item sidenav menu_lateral">
        <div class="menu_clientes"> <a href="clientes.html" title="Clientes"><img src="./img/users-svgrepo-com.svg" alt="Clientes"></a></div>
        <div class="menu_servicos"> <a href="orcamento.html" title="Serviços"><img src="./img/tools-svgrepo-com.svg" alt="Serviços"></a></div>
        <div class="menu_agendamentos"> <a href="agendamento.html" title="Agendamentos"><img src="./img/calendar-svgrepo-com.svg" alt="Agendamentos"></a></div>
        <div class="menu_tecnicos"> <a href="tecnicos.html" title="Técnicos"><img src="./img/construction-worker-svgrepo-com.svg" alt="Técnicos"></a></div>
      </div>

      <div class="item pesquisa">
        <div class="campo_consulta">
            <input class="campo_pesquisa" type="text" name="consulta" placeholder="Digite o nome">
            <div class="radio_pessoa_filter">
              <input  type="checkbox" value="pf" id="pessoaFisicaFilter" name="tipo_pessoa">
              <label for="pessoaFisica">Pessoa Física</label>
              <input  type="checkbox" value="pj" id="pessoaJuridicaFilter" name="tipo_pessoa">
              <label for="pessoaJuridica">Pessoa Jurídica</label>
            </div>
            <button id="btn_search" type="submit">Pesquisar</button>
            <button id="btn_refresh" type="submit"></button>
        </div>
        <div class="titulo_tabela"><h2>Clientes</h2></div>
        <div class="item btn">
            <button id="open-cadastro-form" class=" btn_crud btn_novo" title="Novo cadastro"></button>
        </div>
        
      </div>
      <div class="item tabela">
        <div class="tabela_clientes">
          <table id="tb_cliente">
            <thead>
              <tr class="cabecalho_tabela_cliente">
                <th>🗹</th>
                <th>ID</th>
                <th>Nome/Razão Social</th>
                <th>Email</th>
                <th>CPF/CNPJ</th>
                <th>Telefone</th>
                <th>Endereço</th>
                <th></th>
            </tr>
            </thead>
            <tbody>
                <?php foreach($clientes as $cod => $cli){ ?>
                    <td><input type="checkbox" id="id-<?=$cod?>" class="checkbox-item" /></td>
                    <td><?=$cli->cod?></td>
                    <td><?=$cli->nome?></td>
                    <td><?=$cli->email?></td>
                    <td><?=$cli->cpf_cnpj?></td>
                    <td><?=$cli->tel?></td>
                    <td><?=$cli->cep?></td>
                    <td><?= ?></td>
                    <td><div class="btn_crud btn_acoes" >
                <button id="edit-<?=$cli->cod?>" class="btn_crud btn_altera" type="button" data-action="edit"></button>
                <button id="agenda-<?=$cli->cod?>" class="btn_crud btn_agenda" type="button"></button>
                <button id="delete-<?=$cli->cod?>" class="btn_crud btn_exclui" type="button" data-action="delete"></button></div></td>
                <?php }?>
                <!--
                <td><input type="checkbox" id="id-${index}" class="checkbox-item" /></td>  
                <td>${cliente.numId}</td>
                <td>${cliente.nome}</td>
                <td>${cliente.email}</td>
                <td>${cliente.cpf}</td>
                <td>${cliente.telefone1}<br>${cliente.telefone2}</td>
                <td>${cliente.rua}, ${cliente.numero} ${cliente.bairro}, ${cliente.cidade}-${cliente.estado} ${cliente.complemento} ${cliente.cep}</td>

                <td><div class="btn_crud btn_acoes" >
                <button id="edit-${index}" class="btn_crud btn_altera" type="button" data-action="edit"></button>
                <button id="agenda-${index}" class="btn_crud btn_agenda" type="button"</button>
                <button id="delete-${index}" class="btn_crud btn_exclui" type="button" data-action="delete"></button></div></td>
  -->
            </tbody>
          </table>
        </div>
      </div>
    </section>
    </div>

<div id="fade"></div>
      <div id="cadastro-form-cliente" >
      <div class="cadastro-form-header">
        <h2>Cadastro de cliente</h2>
        <button id="close-cadastro-form" class="close-form-cliente"></button>
      </div>
      <div class="cadastro-form-body">
        <form id = "form">
          <div class="input-group">
            <div class="espaco_form"><p>Dados Cadastrais</p></div>
            <div class="radio_pessoa">
              <input  type="radio" value="pf" id="pessoaFisica" name="tipo_pessoa" checked>
              <label for="pessoaFisica">Pessoa Física</label>
              <input  type="radio" value="pj" id="pessoaJuridica" name="tipo_pessoa">
              <label for="pessoaJuridica">Pessoa Jurídica</label>
            </div>
            <div class="input-box">
              <label id="nome_label" for="nome">Nome Completo*</label>
              <input type="text" id="nome" data-index="new" class="form-field" placeholder="Digite o nome" required>
            </div>
            <div class="input-box">
              <label id="nome_repres_label" class="hidden" for="nome_repres">Representante</label>
              <input type="text" id="nome_repres"  class="form-field hidden" placeholder="Digite o nome do representante" >
            </div>
            <div class="input-box">
              <label id="cpf_label" for="cpf">CPF*</label>
              <input type="text" id="cpf" class="form-field" placeholder="Apenas números" minlength="11" maxlength="14" required>
            </div>
            <div class="input-box">
              <label for="email">Email</label>
              <input type="email" id="email" class="form-field" placeholder="email@email.com">
            </div>
          
            <div class=" input-box">
              <label for="tel1">Telefone comercial*</label>
              <input type="tel" id="tel1" class="form-field" placeholder="(XX) XXXXXX-XXXX " maxlength="11" required>
            </div>
            <div class=" input-box">
              <label for="tel1" id="tel2_label">Telefone pessoal</label>
              <input type="tel" id="tel2" class="form-field" placeholder="(XX) XXXXXX-XXXX " maxlength="11">
            </div>
            <div class="espaco_form"><p>Endereço</p></div>
            <div class="input-box">
              <label for="cep">CEP*</label>
              <input type="text" id="cep" class="cep-form-field" placeholder="Digite o cep do cliente" required minlength="8" maxlength="8">
            </div>
            <div class="input-box">
              <label for="rua">Rua</label>
              <input type="text" id="rua" class="cep-form-field" placeholder="Rua" required disabled>
            </div>
            <div class="input-box">
              <label for="numero">Número*</label>
              <input type="text" id="numero" class="cep-form-field" placeholder="Digite o número da residência" required disabled>
            </div>
            <div class="input-box">
              <label for="complemento">Complemento</label>
              <input type="text" id="complemento" class="cep-form-field" placeholder="Digite o complemento" disabled>
            </div>
            <div class="input-box">
              <label for="bairro">Bairro</label>
              <input type="text" id="bairro" class="cep-form-field" placeholder="Bairro" disabled>
            </div>
            <div class="input-box">
              <label for="cidade">Cidade</label>
              <input type="text" id="cidade" class="cep-form-field" placeholder="Cidade" required disabled>
            </div>
            <div class="input-box">
              <label for="estado">Estado</label>
              <select id="estado" class="form-field cep-form-field form-select"  required disabled>
                <option selected>Selecione o Estado</option>
              <option value="AC">Acre</option>
              <option value="AL">Alagoas</option>
              <option value="AP">Amapá</option>
              <option value="AM">Amazonas</option>
              <option value="BA">Bahia</option>
              <option value="CE">Ceará</option>
              <option value="DF">Distrito Federal</option>
              <option value="ES">Espírito Santo</option>
              <option value="GO">Goiás</option>
              <option value="MA">Maranhão</option>
              <option value="MT">Mato Grosso</option>
              <option value="MS">Mato Grosso do Sul</option>
              <option value="MG">Minas Gerais</option>
              <option value="PA">Pará</option>
              <option value="PB">Paraíba</option>
              <option value="PR">Paraná</option>
              <option value="PE">Pernambuco</option>
              <option value="PI">Piauí</option>
              <option value="RJ">Rio de Janeiro</option>
              <option value="RN">Rio Grande do Norte</option>
              <option value="RS">Rio Grande do Sul</option>
              <option value="RO">Rondônia</option>
              <option value="RR">Roraima</option>
              <option value="SC">Santa Catarina</option>
              <option value="SP">São Paulo</option>
              <option value="SE">Sergipe</option>
              <option value="TO">Tocantins</option>
            </select>              
            </div>
          </div>
        
        </form>
        <div class="form-button">
          <button id="cadastrarCliente">Salvar</button>
          <button id="limparForm">Limpar</button>
          <p>* preenchimento obrigatório</p>
        </div>
      </div>
      </div>



    <footer>
      <p>&copy Todos os direitos reservados - 2024 <a href="../../index.html">login</a></p>
    </footer>
    <script src="../../js/clientes.js"></script>

</body>
</html>
