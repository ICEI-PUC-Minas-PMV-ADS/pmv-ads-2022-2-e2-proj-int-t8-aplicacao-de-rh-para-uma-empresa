const date = new Date();
const dateEntradaBtn = document.querySelector(".btn-entrada");
const dateEntradaP = document.querySelector(".p-entrada");
const dateSaidaBtn = document.querySelector(".btn-saida");
const dateSaidaP = document.querySelector(".p-saida");
const dateEntradaValue = new Date();

dateEntradaBtn.addEventListener("click", () => {
  const hoursEntrada = dateEntradaValue.getHours();
  const minutesEntrada = dateEntradaValue.getMinutes();
  //dateEntradaP.innerHTML = dateEntradaValue;
  dateEntradaP.innerHTML = `${Number(hoursEntrada)}:${Number(minutesEntrada)}`;
});

dateSaidaBtn.addEventListener("click", () => {
  const dateSaidaValue = new Date();
  const hoursSaida = dateSaidaValue.getHours();
  const minutesSaida = dateSaidaValue.getMinutes();
  dateSaidaP.innerHTML = `${Number(hoursSaida)}:${Number(minutesSaida)}`;
});
