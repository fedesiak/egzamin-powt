import 'bootstrap/dist/css/bootstrap.css';
import './App.css';
import { useState } from 'react';
function App() {

  const [tablica, setTablica] = useState([
        {id: 0, alt: "Mak", filename: "obraz1.jpg", category:1, downloads: 35},
    {id: 1, alt:"Bukiet", filename: "obraz2.jpg", category: 1, downloads: 43},
    {id: 2, alt:"Dalmatyńczyk", filename: "obraz3.jpg", category:2, downloads: 2},
    {id: 3, alt:"Świnka morska", filename: "obraz4.jpg", category:2, downloads: 53},
    {id: 4, alt:"Rotwailer", filename: "obraz5.jpg", category:2, downloads: 43},
    {id: 5, alt:"Audi", filename: "obraz6.jpg", category:3, downloads: 11},
    {id: 6, alt:"kotki", filename: "obraz7.jpg", category:2, downloads: 22},
    {id: 7, alt:"Róża", filename: "obraz8.jpg", category:1, downloads: 33},
    {id: 8, alt:"Świnka morska", filename: "obraz9.jpg", category:2, downloads: 123},
    {id: 9, alt:"Foksterier", filename: "obraz10.jpg", category:2, downloads: 22},
    {id: 10, alt:"Szczeniak", filename: "obraz11.jpg", category:2, downloads: 12},
    {id: 11, alt:"Garbus", filename: "obraz12.jpg", category:3, downloads: 321}
  ])


    const [kwiaty, setKwiaty] = useState(true);
    const [zwierzeta, setZwierzeta] = useState(true);
    const [samochody, setSamochody] = useState(true);

    const handleInkrementacja = (id:any) =>{
      const nowaTablica = tablica.map((zdjecie) =>{
        if(zdjecie.id === id){
          return{...zdjecie, downloads: zdjecie.downloads+1}

        }
        return zdjecie;
      })
      setTablica(nowaTablica);

    }
    const [email, setEmail] = useState("");

    const zmiencos = (e:any) =>{
      setEmail(e.target.value);
    }

    const handleWypisz = () => {
      console.log(email);

    }




  return (
    <>
    <h1>Kategorie zdjęć</h1>

<div id='checkboxy'>
<div className="form-check form-switch m-1">
<input className="form-check-input" type="checkbox" id="kwiaty" checked={kwiaty} onChange={() => setKwiaty(!kwiaty)}/>
<label className="form-check-label" htmlFor="kwiaty">Kwiaty</label>
</div>

<div className="form-check form-switch m-1">
<input className="form-check-input" type="checkbox" id="zwierzeta" checked={zwierzeta} onChange={() => setZwierzeta(!zwierzeta)}/>
<label className="form-check-label" htmlFor="zwierzeta">Zwierzęta</label>
</div>

<div className="form-check form-switch m-1">
<input className="form-check-input" type="checkbox" id="samochody" checked={samochody} onChange={() => setSamochody(!samochody)}/>
<label className="form-check-label" htmlFor="samochody">Samochody</label>
</div>
</div>

<div id="blokZdjec" className='row'>
  {tablica.filter((zdjecie) => {
    if(zdjecie.category===1 && kwiaty==true)return true
     else if(zdjecie.category===2 && zwierzeta==true)return true
       else if(zdjecie.category===3 && samochody==true)return true
  })
  .map((zdjecie) =>(
    <div className='col-4'>
    <img 
    src={zdjecie.filename}
     alt={zdjecie.alt}
      />
      <h4>Pobrań:{zdjecie.downloads}</h4>
      <button className='btn btn-success' onClick={() => handleInkrementacja(zdjecie.id)}>Pobierz</button>
      </div>
  ))}
</div>

<form>
<div className="form-group">
<label htmlFor="exampleInputEmail1">Sperma</label>
<input type="email" className="form-control" id="exampleInputEmail1" onChange={zmiencos} />
</div>
<button type='button' className='btn btn-primary' onClick={handleWypisz}>Sperma</button>
</form>



    </>

  )
}

export default App
