import { useState } from 'react'
import './App.css'

function App() {
  const [dias, setDias] = useState(1)
  const [valorDiaria, setValorDiaria] = useState(30)
  const [hospedes, setHospedes] = useState('')

  function calcularReserva() {
    const quantidade = hospedes.split(',').filter(h => h.trim()).length
    let total = dias * valorDiaria
    if (dias > 10) total *= 0.9

    alert(`Hóspedes: ${quantidade}\nValor total: R$ ${total}`)
  }

  return (
    <main className="container">
      <section className="card">
        <header className="header">
          <h1>Hotel TransilDev</h1>
          <p>Reserva inteligente • .NET + React</p>
        </header>

        <div className="grid">
          <div className="field">
            <label>Dias</label>
            <input type="number" value={dias} onChange={e => setDias(+e.target.value)} />
          </div>

          <div className="field">
            <label>Valor da diária</label>
            <input type="number" value={valorDiaria} onChange={e => setValorDiaria(+e.target.value)} />
          </div>

          <div className="field full">
            <label>Hóspedes</label>
            <input
              type="text"
              placeholder="Ana, João"
              value={hospedes}
              onChange={e => setHospedes(e.target.value)}
            />
          </div>
        </div>

        <button onClick={calcularReserva}>Calcular Reserva</button>
      </section>
    </main>
  )
}

export default App
