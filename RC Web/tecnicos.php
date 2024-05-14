<?php
if(session_status() == PHP_SESSION_NONE){
  session_start();
}

require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/db/db.php');
require_once($_SERVER['DOCUMENT_ROOT'] .'/Projeto_RC/RC Web/php/cls/tecnico.php');
require_once($_SERVER['DOCUMENT_ROOT'] .'/Projeto_RC/RC Web/php/cls/cep.php');

if( !isset($_SESSION['USER']) )
{
  header('Location: ./index.php');
}

if(isset($_POST["SELECT"]))
{
  $tecnicos = DB::getTecnicosPorNome($_POST["SELECT"]??"");
  unset($_POST["SELECT"]);
}
else
{
  $tecnicos = DB::getTecnicos();
}

$ceps = DB::getCEPs();
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Técnicos - RC Ar-condicionado</title>
    <link rel="stylesheet" href="./css/global.css">
    <link rel="stylesheet" href="./css/tecnicos.css">

    <link rel="shortcut icon" href="img/winter32.png" type="image/x-icon">
</head>
<body>
  <div>
    <section class="grid grid-template-row">
      <div class="item nav">
        <header class="header-nav">
          <h1>Bem-vindo, <span class="nome_func"> <?= $_SESSION['USER'] ?> </span>!</h1>
          <div class="btn_menu">
            <div class="btn_perfil"><a href=""><img src="./img/user-circle-svgrepo-com.svg" alt="foto do usuário"></a></div>
            <div class="btn_logout"><a href="index.php"><img src="./img/logout-svgrepo-com.svg" alt="logout"></a></div>
          </div>
        </header>
      </div>
      <div class="item sidenav menu_lateral">
        <div class="menu_clientes"> <a href="clientes.php" title="clientes"><img src="./img/users-svgrepo-com.svg" alt="clicentes"></a></div>
        <div class="menu_servicos"> <a href="orcamento.php" title="Serviços"><img src="./img/tools-svgrepo-com.svg" alt="Serviços"></a></div>
        <div class="menu_agendamentos"> <a href="agendamento.php" title="Agendamentos"><img src="./img/calendar-svgrepo-com.svg" alt="Agendamentos"></a></div>
        <div class="menu_tecnicos"> <a href="tecnicos.php" title="Técnicos"><img src="./img/construction-worker-svgrepo-com.svg" alt="Técnicos"></a></div>
      </div>

      <div class="item pesquisa">
        <div class="campo_consulta">
            <input class="campo_pesquisa" type="text" name="consulta" placeholder="Digite o nome">
            <button id="btn_search" type="submit">Pesquisar</button>
            <button id="btn_refresh" type="submit"></button>
        </div>
        <div class="titulo_tabela"><h2>Técnicos</h2></div>
        <div class="item btn">
            <button id="open-cadastro-form" class=" btn_crud btn_novo" title="Novo cadastro" ontecck="clearModal()"></button>
        </div>
        
      </div>
      <div class="item tabela">
        <div class="tabela_tecnicos">
          <table id="tb_tecnico">
            <thead>
              <tr class="cabecalho_tabela_tecnico">
                <th>🗹</th>
                <th>ID</th>
                <th>Nome</th>
                <th>CPF</th>
                <th>Telefone</th>
                <th>Email</th>
                <th></th>
            </tr>
            </thead>
            <tbody>
            <?php foreach($tecnicos as $cod => $tec){ ?>
                  <tr  id="tec-id-<?=$cod?>">
                    <td><input type="checkbox" id="id-<?=$cod?>" class="checkbox-item" /></td>
                    <td id="cod-<?=$cod?>"><?=$cod?></td>
                    <td id="nome-<?=$cod?>"><?=$tec->getNome()?></td>
                    <td id="cpf-<?=$cod?>"><?=$tec->getCPF()?></td>
                    <td >
                        <span id="tel1-<?=$cod?>"><?=$tec->getTel1()?></span>
                        <span id="tel2-<?=$cod?>"><?=$tec->getTel2()?></span>
                    </td>
                    <td id="email-<?=$cod?>"><?=$tec->getEmail()?></td>
                    <td>
                      <span id="cep-<?=$cod?>"><?=$tec->getCEP()?></span>,
                      <span id="uf-<?=$cod?>"><?=$ceps[$tec->getCEP()]->uf?></span>,  
                      <span id="cidade-<?=$cod?>"><?=$ceps[$tec->getCEP()]->cidade?></span>, 
                      <span id="bairro-<?=$cod?>"><?=$ceps[$tec->getCEP()]->bairro?></span>, 
                      <span id="logra-<?=$cod?>"><?=$ceps[$tec->getCEP()]->logra?></span>, 
                      <span id="end-nro-<?=$cod?>"><?=$tec->getEndNro()?></span>, 
                      <span id="end-cmplto-<?=$cod?>"><?=$tec->getEndCmplto()?></span>
                    </td>

                    <td>
                        <div class="btn_crud btn_acoes" >
                <button id="edit-<?=$cod?>" class="btn_crud btn_altera" type="button" data-action="edit"></button>
                <button id="agenda-<?=$cod?>" class="btn_crud btn_agenda" type="button"></button>
                <button id="delete-<?=$cod?>" class="btn_crud btn_exclui" type="button" data-action="delete"></button>
                        </div>
                    </td>
                </tr>
                <?php }?>
            </tbody>
          </table>
        </div>
      </div>
    </section>
    </div>

<div id="fade"></div>
      <div id="cadastro-form-tecnico" >
      <div class="cadastro-form-header">
        <h2>Cadastro de técnico</h2>
        <button id="close-cadastro-form" class="close-form-tecnico"></button>
      </div>
      <div class="cadastro-form-body">
        <form id="form" name="form" method="POST" action="./php/pg/crud_tec.php">
          <div class="input-group">
          <div class="espaco_form"><p>Dados Cadastrais</p></div>
          <input type="hidden" id="cod" name="cod" value="">
            <div class="input-box">
              <label for="nome">Nome Completo*</label>
              <input type="text" id="nome" name="nome" data-index="new" class="form-field" placeholder="Digite o nome" required>
            </div>
            <div class="input-box">
              <label for="cpf">CPF*</label>
              <input type="text" id="cpf" name="cpf" class="form-field" placeholder="Apenas números" maxlength="11" required>
            </div>
            <div class="input-box">
              <label for="email">E-mail*</label>
              <input type="email" id="email" name="email" class="form-field" placeholder="email@email.com" required>
            </div>
          
            <div class=" input-box">
              <label for="tel1">Telefone comercial*</label>
              <input type="tel" id="tel1" name="tel1" class="form-field" placeholder="Apenas números com DDD" maxlength="12" required>
            </div>
            <div class=" input-box">
              <label for="tel1">Telefone pessoal</label>
              <input type="tel" id="tel2" name="tel2" class="form-field" placeholder="Apenas números com DDD" maxlength="12">
            </div>

            <div class="espaco_form">
              <p>Endereço</p>
            </div>
            <div class="input-box">
              <label for="cep">CEP</label>
              <input type="text" id="cep" name="cep" class="cep-form-field" placeholder="Digite o cep do profissional" required minlength="8" maxlength="8">
            </div>
            <div class="input-box">
              <label for="rua">Rua</label>
              <input type="text" id="rua" name="rua" class="cep-form-field" placeholder="Rua" required disabled>
            </div>
            <div class="input-box">
              <label for="numero">Número*</label>
              <input type="text" id="numero" name="end_nro" class="cep-form-field" placeholder="Digite o número da residência" required disabled>
            </div>
            <div class="input-box">
              <label for="complemento">Complemento</label>
              <input type="text" id="complemento" name="end_cmplto" class="cep-form-field" placeholder="Digite o complemento" disabled>
            </div>
            <div class="input-box">
              <label for="bairro">Bairro</label>
              <input type="text" id="bairro" name="bairro" class="cep-form-field" placeholder="Bairro" disabled>
            </div>
            <div class="input-box">
              <label for="cidade">Cidade</label>
              <input type="text" id="cidade" name="cidade" class="cep-form-field" placeholder="Cidade" required disabled>
            </div>
            <div class="input-box">
              <label for="estado">Estado</label>
              <select id="estado" name="uf" class="form-field cep-form-field form-select" required disabled>
                <option selected name="uf" value="">Selecione o Estado</option>
                <option name="AC" value="AC">Acre</option>
                <option name="AL" value="AL">Alagoas</option>
                <option name="AP" value="AP">Amapá</option>
                <option name="AM" value="AM">Amazonas</option>
                <option name="BA" value="BA">Bahia</option>
                <option name="CE" value="CE">Ceará</option>
                <option name="DF" value="DF">Distrito Federal</option>
                <option name="ES" value="ES">Espírito Santo</option>
                <option name="GO" value="GO">Goiás</option>
                <option name="MA" value="MA">Maranhão</option>
                <option name="MT" value="MT">Mato Grosso</option>
                <option name="MS" value="MS">Mato Grosso do Sul</option>
                <option name="MG" value="MG">Minas Gerais</option>
                <option name="PA" value="PA">Pará</option>
                <option name="PB" value="PB">Paraíba</option>
                <option name="PR" value="PR">Paraná</option>
                <option name="PE" value="PE">Pernambuco</option>
                <option name="PI" value="PI">Piauí</option>
                <option name="RJ" value="RJ">Rio de Janeiro</option>
                <option name="RN" value="RN">Rio Grande do Norte</option>
                <option name="RS" value="RS">Rio Grande do Sul</option>
                <option name="RO" value="RO">Rondônia</option>
                <option name="RR" value="RR">Roraima</option>
                <option name="SC" value="SC">Santa Catarina</option>
                <option name="SP" value="SP">São Paulo</option>
                <option name="SE" value="SE">Sergipe</option>
                <option name="TO" value="TO">Tocantins</option>
              </select>
            </div>
            <input type="hidden" id="op" name="op" value="">
          </div>
          <p>* preenchimento obrigatório</p>
          <div class="form-button">
            <button id="cadastrarTecnico">Salvar</button>
            <button id="limparForm">Limpar</button>
          </div>
        </form>
      </div>
      </div>



    <footer>
      <p>&copy Todos os direitos reservados - 2024 <a href="index.php">login</a></p>
    </footer>
    <script src="./js/tecnico/tecnicos_php.js"></script>

</body>
</html>
