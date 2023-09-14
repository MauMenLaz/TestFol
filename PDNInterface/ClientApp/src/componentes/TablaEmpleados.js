import { Button, Table } from "reactstrap";
import Swal from 'sweetalert2'



const TablaEmpleados = ({ data, setEditar, mostrarModal, setMostrarModal }) => {

    const enviarDatos = (empleado, estado) => {
        if (estado === 0) {
            Swal.fire({
                title: '¿Deseas eliminar este elemento?',
                text: "Esta accion no se puede deshacer",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText: '¡No!',
                confirmButtonText: '¡Si!'
            }).then((result) => {
                if (result.isConfirmed) {
                    setEditar(empleado, estado)
                    empleado.estatus = false;
                    mostrarModal = false
                }
            })
        } else if (estado === 1) {
            setEditar(empleado, estado)
            setMostrarModal(!mostrarModal)
        }
    }

    return (
        <Table striped responsive>
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Apellido Paterno</th>
                    <th>Apellido Materno</th>
                    <th>Area</th>
                    <th>FechaNacimiento</th>
                    <th>Sueldo</th>
                    <th>FechaCreacion</th>
                    <th>Opciones</th>
                </tr>
            </thead>
            <tbody>
                {
                    (data.length < 1) ? (
                        <tr>
                            <td colSpan="8" align="center" >Sin Registros</td>
                        </tr>
                    ) : (
                        data.map((item) => (

                            <tr key={item.idempleado}>
                                <td>{item.nombre}</td>
                                <td>{item.apaterno}</td>
                                <td>{item.amaterno}</td>
                                <td>{item.areaDesc}</td>
                                <td>{new Date(item.fechaNacimiento).toLocaleString()}</td>
                                <td>{item.sueldo.toLocaleString('es-MX', { style: 'currency', currency: 'MXN' })}</td>
                                <td>{new Date(item.fechaCreacion).toLocaleString()}</td>
                                <td>
                                    <Button color="primary" size="sm" className="me-2" onClick={() => enviarDatos(item,1)}>Editar</Button>
                                    <Button color="danger" size="sm" className="me-2" onClick={() => enviarDatos(item, 0)}>Eliminar</Button>
                                </td>
                            </tr>
                        ))
                    )
                }
            </tbody>
        </Table>

    )
}

export default TablaEmpleados;