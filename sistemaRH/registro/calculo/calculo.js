const btn = document.querySelector(".btn");
const p = document.querySelector(".p");
btn.addEventListener("click", function (e) {
  const inputHoras = document.querySelector(".input-horas");
  const inputValor = document.querySelector(".input-valor");
  const inputHorasValue = parseInt(inputHoras.value);
  const inputValorValue = parseInt(inputValor.value);
  const calculo = parseInt(inputHoras.value) * parseInt(inputValor.value);

  p.innerHTML = `O valor a ser recebido sera de: R$ ${calculo}.00`;
  e.preventDefault();
});
