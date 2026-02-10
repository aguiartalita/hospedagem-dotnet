import { useState } from 'react'

function App() {
  const [dias, setDias] = useState(1)
  const [valorDiaria, setValorDiaria] = useState(30)
  const [hospedes, setHospedes] = useState('')

  function calcularReserva() {
    const quantidadeHospedes = hospedes.split(',').filter(h => h.trim()).length
    let total = dias * valorDiaria

    if (dias > 10) {
      total *= 0.9
    }

    alert(
      `Hóspedes: ${quantidadeHospedes}\nValor total: R$ ${total}`
    )
  }

  return (
    <div style={{ maxWidth: 400, margin: '2rem auto', fontFamily: 'Arial' }}>
      <h2>Reserva de Hospedagem</h2>

      <label>Dias reservados</label>
      <input
        type="number"
        value={dias}
        onChange={e => setDias(Number(e.target.value))}
      />

      <label>Valor da diária</label>
      <input
        type="number"
        value={valorDiaria}
        onChange={e => setValorDiaria(Number(e.target.value))}
      />

      <label>Hóspedes (separados por vírgula)</label>
      <input
        type="text"
        placeholder="Ex: Ana, João"
        value={hospedes}
        onChange={e => setHospedes(e.target.value)}
      />

      <button onClick={calcularReserva} style={{ marginTop: '1rem' }}>
        Calcular Reserva
      </button>
    </div>
  )
}

export default App
