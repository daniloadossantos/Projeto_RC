//Tabela


//Abrir formulario 
const openForm = () => {
    document.getElementById('cadastro-form-tecnico')
      .classList.add('active');
}
  
const closeForm = () => {
    document.getElementById('cadastro-form-tecnico')
        .classList.remove('active');
    clearFields()
    clearCepForm()
}
  
//FUNÇÕES
function gerarNumeroUnico() {
    let numero = Math.floor(Math.random() * 1000);
    return numero.toString().padStart(4, '0');
}
  
  
// Função para validar CPF e formatar
function validarCPF(cpf) {
    // Remove caracteres não numéricos
    cpf = cpf.replace(/\D/g, '');

    if (!cpf || typeof cpf !== 'string' || cpf.length !== 11) return { valido: false, numero: cpf }; // Verifica se o CPF tem 11 dígitos

    // Verifica se todos os caracteres são iguais
    if (/^(\d)\1{10}$/.test(cpf)) return { valido: false, numero: cpf };

    // Calcula o primeiro dígito verificador
    let soma = 0;
    for (let i = 0; i < 9; i++) soma += parseInt(cpf.charAt(i)) * (10 - i);
    let resto = soma % 11;
    let digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

    // Verifica o primeiro dígito verificador
    if (parseInt(cpf.charAt(9)) !== digitoVerificador1) return { valido: false, numero: cpf };

    // Calcula o segundo dígito verificador
    soma = 0;
    for (let i = 0; i < 10; i++) soma += parseInt(cpf.charAt(i)) * (11 - i);
    resto = soma % 11;
    let digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

    // Verifica o segundo dígito verificador
    if (parseInt(cpf.charAt(10)) !== digitoVerificador2) return { valido: false, numero: cpf };

    // Retorna o CPF formatado
    let cpfFormatado = cpf.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, '$1.$2.$3-$4');
    return cpfFormatado;
}
  
// Função para validar CPF ou CNPJ e formatar
function validarDocumento(numeroString) {
    // Remove caracteres não numéricos e converte para número
    let numero = parseInt(numeroString.replace(/\D/g, ''));

    // Verifica o número de dígitos
    if (isNaN(numero) || numeroString.length !== 11 && numeroString.length !== 14) {
        // Se o número não puder ser convertido para um número válido ou não tiver o tamanho adequado, retorna falso
        return alert("Número de documento inválido.");

    } else if (numeroString.length === 11) {
        // Se tiver 11 dígitos, chama a função para validar CPF
        return validarCPF(numero.toString());
    } else {
        // Se tiver 14 dígitos, chama a função para validar CNPJ
        return validarCNPJ(numero.toString());
    }
}
  
function formatarTelefone(telefone) {
    // Remove todos os caracteres não numéricos
    telefone = telefone.replace(/\D/g, '');

    // Verifica se o número de telefone é válido (deve ter 10 ou 11 dígitos)
    if (telefone.length === 10) {
        // Formata o número de telefone para (XX) XXXX-XXXX
        return '(' + telefone.substring(0, 2) + ') ' + telefone.substring(2, 6) + '-' + telefone.substring(6, 10);
    } else if (telefone.length === 11) {
        // Formata o número de telefone para (XX) XXXXX-XXXX
        return '(' + telefone.substring(0, 2) + ') ' + telefone.substring(2, 7) + '-' + telefone.substring(7, 11);
    } else {
        // Retorna o número de telefone original se não for válido
        return telefone;
    }
}

// AutoComplete CEP

const cepInput = document.querySelector("#cep");
const ruaInput = document.querySelector("#rua");
const cidadeInput = document.querySelector("#cidade");
const bairroInput = document.querySelector("#bairro");
const estadoInput = document.querySelector("#estado");
const numeroInput = document.querySelector("#numero");
const complementoInput = document.querySelector("#complemento");

// Evento para pegar o CEP
cepInput.addEventListener("keyup", (event) => {
    const inputValue = event.target.value;

    // Checar o tamanho do CEP
    if (inputValue.length === 8) {
        getAddress(inputValue);
    }
});

// Pegar o endereço na API
const getAddress = async (cep) => {
    cepInput.blur();

    const apiUrl = `https://viacep.com.br/ws/${cep}/json/`;

    try {
        const response = await fetch(apiUrl);
        const data = await response.json();

        // Verificar se o CEP é válido
        if (!data.erro) {
        fillAddressFields(data);
        toggleAddressFields(true); // Habilitar campos relacionados ao endereço
        } else {
        alert("CEP não encontrado. Por favor, verifique o CEP digitado.");
        }
    } catch (error) {
        console.error("Ocorreu um erro ao buscar o endereço:", error);
    }
};

// Preencher os campos relacionados ao endereço com os dados do CEP
const fillAddressFields = (data) => {
    cepInput.value = data.cep || "";
    ruaInput.value = data.logradouro || "";
    cidadeInput.value = data.localidade || "";
    bairroInput.value = data.bairro || "";
    estadoInput.value = data.uf || "";
};

// Alternar a habilitação dos campos relacionados ao endereço
const toggleAddressFields = (enabled) => {
    const addressFields = document.querySelectorAll(".cep-form-field");
    addressFields.forEach((field) => {
        if (field.id == "cep" || field.id == "numero" || field.id == "complemento") {  // se n for cep, num ou comp vai ser desabilitado
            field.disabled = !enabled;
        }
        else {
            field.disabled = enabled;
        }
    });
};

// Evento para pegar o CEP
numeroInput.addEventListener("keyup", (event) => {
    const inputValue = event.target.value;

    // Checar o tamanho do número
    if (inputValue.length > 0) {
        toggleAddressFields(true);
        }
});


//CRUD Tecnico

const deleteTecnico = (index) => {
    setOperation("DELETE")
    setCodigo(index)
    fillFields(index);
    cepFieldsEnable(true);
    submitForm();
    cepFieldsEnable(false);
}

const isValidFields = () => {
    return document.getElementById('form').reportValidity()
}

//Interação com formulario

const clearFields = () => {
    const fields = document.querySelectorAll('.form-field')
    document.getElementById('op').setAttribute('value', '')
    fields.forEach(field => field.value = "")
}
const clearCepForm = () => {
    const fields = document.querySelectorAll('.cep-form-field')
    fields.forEach(field => field.value = "")
}

const cepFieldsEnable = (enable) => {
    const fields = document.querySelectorAll('.cep-form-field')
    if(enable){
      fields.forEach(field => field.disabled = false)
    }else{
      fields.forEach(field => field.disabled = true)
      document.getElementById('cep').disabled = false;
    }
}

const fillFields = (id) => {      
    document.getElementById('nome').value         = document.getElementById(`nome-${id}`).textContent
    document.getElementById('cpf').value          = document.getElementById(`cpf-${id}`).textContent 
    document.getElementById('tel1').value         = document.getElementById(`tel1-${id}`).textContent
    document.getElementById('tel2').value         = document.getElementById(`tel2-${id}`).textContent
    document.getElementById('email').value        = document.getElementById(`email-${id}`).textContent
    document.getElementById('cep').value          = document.getElementById(`cep-${id}`).textContent 
    document.getElementById('rua').value          = document.getElementById(`logra-${id}`).textContent
    document.getElementById('numero').value       = document.getElementById(`end-nro-${id}`).textContent 
    document.getElementById('bairro').value       = document.getElementById(`bairro-${id}`).textContent 
    document.getElementById('cidade').value       = document.getElementById(`cidade-${id}`).textContent 
    document.getElementById('estado').value       = document.getElementById(`uf-${id}`).textContent 
    document.getElementById('complemento').value  = document.getElementById(`end-cmplto-${id}`).textContent
    setCodigo(id)
}

const editTecnico = (index) => {
    setOperation('UPDATE')
    setCodigo(index)
    fillFields(index)
    document.getElementById("numero").disabled =  false;
    document.getElementById("complemento").disabled = false;
    openForm()
}

const getNome = (id) => {
    return document.getElementById(`nome-${id}`).textContent
}

const editDelete = (event) => {
    if (event.target.type == 'button') {
        const [action, index] = event.target.id.split('-')

        if (action == 'edit') {
            editTecnico(index)
        } else {
            const response = confirm(`Deseja realmente excluir o registro de ${getNome(index)}`)
            if (response) {
                deleteTecnico(index)
            }
        }
    }
}

const isAnyCheckboxSelected = () => {
    const checkboxes = document.querySelectorAll('.checkbox-item');
    for (const checkbox of checkboxes) {
        if (checkbox.checked) {
        return true;
        }
    }
    return false;
};



const toggleActionButtonsVisibility = () => {
    const checkboxes = document.querySelectorAll('.checkbox-item');
    for (const checkbox of checkboxes) {
        const row = checkbox.closest('tr');
        const actionButtons = row.querySelector('.btn_acoes');
        if (checkbox.checked) {
            actionButtons.style.display = 'inline-flex';
        } else {
            actionButtons.style.display = 'none';
        }
    }
};

  
const searchByName = () => {
    const searchTerm = document.querySelector('input[name="consulta"]').value.toLowerCase();
    setOperation('SELECT', searchTerm);
    submitForm('./tecnicos.php');
};


// Tipo de operação a ser utlizada UPDATE/CREATE/DELETE
// e um valor para o caso especifico do SELECT
const setOperation = (op, value = true) => {
    document.getElementById('op').name = op
    document.getElementById('op').value = value
}

// Define o código do cliente a ser UPDATE/DELETE
const setCodigo = (cod) => {
    document.getElementById('cod').value = cod
}

// Atualiza a página inteira
const refreshTable = () => {
    setCodigo(0)
    setOperation("", "")
    location.reload()
    submitForm('./tecnicos.php')
}

// Envia o formulário
// page: especifica a pagina utilizada (ex: ./clientes.php)
const submitForm = (page = null) => {
    if(page !== null)
    {
        document.form.action = page;
    }
    document.getElementById('form').submit();
}

const saveTecnico = async function() {
    if(isValidFields()){
        cepFieldsEnable(true);
        submitForm();
    }
}

const addNewTecnico = ()=> {
    setOperation('CREATE')
    document.getElementById('complemento').disabled = false
    document.getElementById('numero').disabled = false;
    openForm()
}
  
  //Eventos
  document.getElementById('cadastrarTecnico')
    .addEventListener('click', saveTecnico)
  
  document.querySelector('#tb_tecnico>tbody')
    .addEventListener('click', editDelete)
  
  document.getElementById('close-cadastro-form')
    .addEventListener('click', closeForm)
  
  document.getElementById('open-cadastro-form')
    .addEventListener('click', addNewTecnico)
  
  document.getElementById('btn_refresh')
    .addEventListener('click', refreshTable)
  
  document.getElementById('btn_search').addEventListener('click', (event) => {
    event.preventDefault();
    searchByName();
  });
  
  document.getElementById('limparForm')
    .addEventListener('click', clearFields)
  
  document.getElementById('limparForm')
    .addEventListener('click', clearCepForm)
  