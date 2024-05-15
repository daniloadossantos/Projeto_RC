<?php
if(session_status() == PHP_SESSION_NONE){
    session_start();
}
  
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/db/db.php');
require_once($_SERVER['DOCUMENT_ROOT'] .'/Projeto_RC/RC Web/php/cls/cliente.php');
require_once($_SERVER['DOCUMENT_ROOT'] .'/Projeto_RC/RC Web/php/cls/tecnico.php');
require_once($_SERVER['DOCUMENT_ROOT'] .'/Projeto_RC/RC Web/php/cls/solicitacoes.php');
require_once($_SERVER['DOCUMENT_ROOT'] .'/Projeto_RC/RC Web/php/cls/cep.php');

if( !isset($_SESSION['USER']) )
{
header('Location: ./index.php');
}

// if(isset($_POST["SELECT"]))
// {
//   $cli = DB::getSoliPorNomeCliente($_POST["SELECT"]??"");
//   unset($_POST["SELECT"]);
// }
// else
// {
//   $cli = DB::getClientes();
// }

$cli = DB::getClientes();
$ceps = DB::getCEPs();
$tec = DB::getTecnicos();
$sol = DB::getSolicitacoes();
$serv = DB::getServicos();

?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Agendamento - RC Ar-condicionado</title>
  <link rel="stylesheet" href="./css/global.css">
  <link rel="stylesheet" href="./css/agendamento.css">
  <link rel="shortcut icon" href="img/winter32.png" type="image/x-icon">
</head>

<body>
  <div>
    <section class="grid grid-template-row">
      <div class="item nav">
        <header class="header-nav">
          <h1>Bem-vindo, <span class="nome_func">nome</span>!</h1>
          <div class="btn_menu">
            <div class="btn_perfil"><a href=""><img src="./img/user-circle-svgrepo-com.svg" alt="foto do usuário"></a>
            </div>
            <div class="btn_logout"><a href="index.html"><img src="./img/logout-svgrepo-com.svg" alt="logout"></a></div>
          </div>
        </header>
      </div>
      <div class="item sidenav menu_lateral">
        <div class="menu_clientes"> <a href="clientes.php" title="Clientes"><img src="./img/users-svgrepo-com.svg"
              alt="Clientes"></a></div>
        <div class="menu_servicos"> <a href="orcamento.php" title="Serviços"><img src="./img/tools-svgrepo-com.svg"
              alt="Serviços"></a></div>
        <div class="menu_agendamentos"> <a href="agendamento.php" title="Agendamentos"><img
              src="./img/calendar-svgrepo-com.svg" alt="Agendamentos"></a></div>
        <div class="menu_tecnicos"> <a href="tecnicos.php" title="Técnicos"><img
              src="./img/construction-worker-svgrepo-com.svg" alt="Técnicos"></a></div>
      </div>

      <div class="item pesquisa">
        <div class="campo_consulta">
          <input class="campo_pesquisa" type="text" name="consulta" placeholder="Digite o nome">
          <button id="btn_search" type="submit">Pesquisar</button>
          <button id="btn_refresh" type="submit"></button>
        </div>

        <div class="titulo_tabela">
          <h2>Agendamentos</h2>
        </div>
        <div class="item btn">
          <button id="open-cadastro-form" class=" btn_crud btn_novo" title="Novo cadastro"></button>
        </div>

      </div>
      <div class="item tabela">
        <div class="tabela_agendamento">
          <table id="tb_agendamento">
            <thead>
              <tr class="cabecalho_tabela_agendamento">
                <th>🗹</th>
                <th>ID</th>
                <th>Cliente</th>
                <th>Data</th>
                <th>Endereço do Cliente</th>
                <th>Técnico Responsável</th>
                <th>Status</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
            <?php foreach($sol as $cod => $solicitacao){ ?>
                  <tr  id="slc-<?=$cod?>">
                    <td><input type="checkbox" id="id-<?=$cod?>" class="checkbox-item" /></td>
                    <td id="cod-<?=$cod?>"><?=$cod?></td>
                    <td id="cliente-<?=$solicitacao->codCli?>"><?=$cli[$solicitacao->codCli]->nome?></td>
                    <td id="data-<?=$cod?>"><?=$solicitacao->dataAgen?></td>
                    <td>
                      <span id="cep-<?=$cod?>"><?=$ceps[$cli[$solicitacao->codCli]->cep]->cod?></span>,
                      <span id="uf-<?=$cod?>"><?=$ceps[$cli[$solicitacao->codCli]->cep]->uf?></span>,  
                      <span id="cidade-<?=$cod?>"><?=$ceps[$cli[$solicitacao->codCli]->cep]->cidade?></span>, 
                      <span id="bairro-<?=$cod?>"><?=$ceps[$cli[$solicitacao->codCli]->cep]->bairro?></span>, 
                      <span id="logra-<?=$cod?>"><?=$ceps[$cli[$solicitacao->codCli]->cep]->logra?></span>, 
                      <span id="end-nro-<?=$cod?>"><?=$cli[$solicitacao->codCli]->end_nro?></span>, 
                      <span id="end-cmplto-<?=$cod?>"><?=$cli[$solicitacao->codCli]->end_cmplto?></span>
                    </td>
                    <td id="tecnico-<?=$solicitacao->codTec?>"><?=isset($tec[$solicitacao->codTec])? $tec[$solicitacao->codTec]->getNome() : ""?></td>
                    <td>
                      <span id="status-<?=$cod?>"><?=$solicitacao->status?></span>
                      <!-- <?php if($solicitacao->dataConf != ""){ ?>
                        <span id="status-<?=$cod?>">Confirmado</span>
                      <?php }else if($solicitacao->dataExe != ""){ ?>
                        <span id="status-<?=$cod?>">Executado</span>
                      <?php }else if($solicitacao->dataAgen != ""){ ?> 
                        <span id="status-<?=$cod?>">Agendado</span>
                      <?php } ?> -->
                    </td>
                    <td><div class="btn_crud btn_acoes" >
                <button id="edit-<?=$cod?>" class="btn_crud btn_altera" type="button" data-action="edit"></button>
                <button id="delete-<?=$cod?>" class="btn_crud btn_exclui" type="button" data-action="delete"></button></div></td>
                </tr>
                <?php }?>
            </tbody>
          </table>
        </div>
      </div>
    </section>
  </div>

  <div id="cadastro-form-agendamento">
    <div class="cadastro-form-header">
      <h2>Cadastro de agendamento</h2>
      <button id="close-cadastro-form" class="close-form-agendamento"></button>
    </div>
    <div class="cadastro-form-body">
      <form id="form" method="POST" action="./php/pg/crud_age.php">
      <input type="hidden" id="cod" name="cod" value="">
      <input type="hidden" id="codCli" name="codCli" value="">
      <input type="hidden" id="codTec" name="codTec" value="">
        <div class="left-side-form">

          <div class="search-container">
            <div class="input-box">
              <label for="nomeCliente">Nome do Cliente*</label>
              <select id="nome" class="form-field" name="nomeCliente"">
                <option name="nome_cli" value="">Selecione o cliente</option>
                <?php foreach($cli as $cod => $cliente){ ?>
                  <option id="cli-<?=$cod?>" name="nome_cli" value="<?=$cod?>"><?=$cliente->nome?></option>
                <?php } ?>
              </select>
              <div class="input-box">
                <!--<label for="nomeClienteSelecionado">Cliente Selecionado:</label>-->
                <input type="text" id="nomeClienteSelecionado" data-num-id="1" placeholder="Cliente Selecionado" for="nomeClienteSelecionado" readonly>
              </div>
			  <div class="input-box">
				<input type="text" id="enderecoClienteSelecionado" placeholder="Endereço do Cliente Selecionado" readonly>
			  </div>
            </div>

            <div class="input-box">
              <label for="nomeTecnico">Nome do Técnico*</label>
              <select id="nomeTecnico" name="nomeTecnico" >
                <option value="">Selecione o técnico</option>
                <?php foreach($tec as $cod => $tecnico){ ?>
                  <option id="tec-<?=$cod?>" name="nome_tec" value="<?=$cod?>"><?=$tecnico->getNome()?></option>
                <?php } ?>
              </select>
              <div class="input-box">
                <!--<label for="nomeTecnicoSelecionado">Técnico Selecionado:</label>-->
                <input type="text" id="nomeTecnicoSelecionado" placeholder="Técnico Selecionado" for="nomeTecnicoSelecionado" readonly>
              </div>
            </div>
          </div>
        </div>
        <div class="right-side-form">
          <div class="seletor-mes-ano">

            <div id="seletor-ano">
              <label for="ano">Ano:</label>
              <select name="ano" id="ano"></select>
            </div>

            <div id="seletor-mes">
              <label for="mes">Mês:</label>
              <select name="mes" id="mes"></select>
            </div>
          </div>

          <div class="select-container">
            <label for="dia">Dia:</label>
            <select name="dia" id="dia"></select>
          </div>

          <div class="select-container">
            <label for="horario">Horário:</label>
            <select name="hora" id="horario">
                
            </select>
          </div>

          <div class="select-status">
            <label for="status">Status:</label>
            <select name="status" id="status">

              <option name="status" value="Agendado">Agendado</option>
              <option name="status" value="Cumprido">Cumprido</option>
              <option name="status" value="Cancelado pelo cliente">Cancelado pelo cliente</option>
              <option name="status" value="Cancelado pelo técnico">Cancelado pelo técnico</option>

            </select>

          </div>

          <div class="form-button">
            <button id="cadastrarAgendamento" type="submit">Agendar</button>
            <button id="limparForm">Limpar</button>
          </div>

        </div>
        <input type="hidden" id="op" name="op" value="">
      </form>
    </div>
  </div>
  </section>

  <div id="confirmation-message">
    <p>Você tem certeza que deseja continuar?</p>
    <button class="confirmation-button" onclick="esconderDiv('confirmation-message')" value="Sim">Sim</button>
    <button class="confirmation-button" onclick="esconderDiv('confirmation-message')" value="Não">Não</button>
  </div>

  <div id="error-message">
    <p>Oops! Ocorreu um erro no preenchimento do formulário.</p>
    <button class="error-button" onclick="esconderDiv('error-message')">OK</button>
  </div>




  </div>
  <footer>
    <p>Todos os direitos reservados. 2024 <a href="index.php">login</a></p>
  </footer>
  <script src="js/agendamento_php.js"></script>
</body>

</html>