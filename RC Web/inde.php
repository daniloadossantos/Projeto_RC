<?php
session_start();

?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>RC Ar-condicionado</title>
  <link rel="stylesheet" href="css/login.css">
  <link rel="stylesheet" href="css/global.css">
</head>
<body>
  <div class="container">
    <div class="logo">
      <img src="./img/rc.svg" alt="">
    </div>
    <main>
      <div class="box-login">
        <div class="login-form">
          <h2>Bem vindo à RC System</h2>
          <form method="post" id="login-form" action="./php/pg/ck_login.php">
            <div>
              <label for="cod_func">Usuário</label>
              <a href="#"><span>Esqueci meu usuário</span></a>
              <input type="text" id="nome" name="nome" placeholder="Digite o código do usuário" required>
            </div>
            <div>
              <label for="senha">Senha</label>
              <a href="#"><span>Esqueci minha senha</span></a>
              <input type="password" name="senha" id="email" placeholder="Digite sua senha" required>
            </div>
            <button type="submit">Entrar</button>
          </form>
        </div>
      </div>
    </div>
    <footer>
      <p>Todos os direitos reservados. 2024 <a href="clientes.php">clientes</a></p>
    </footer>

  <script src="./js/login_php.js"></script>

</body>
</html>
