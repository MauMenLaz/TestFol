import Swal from 'sweetalert2'
import { Container, Row, Col, Card, CardHeader, CardBody, Button } from "reactstrap"
import TablaEmpleados from "./componentes/TablaEmpleados"
import { useState, useEffect } from "react"
import ModalEmpleado from "./componentes/ModalEmpleado"

const App = () => {

    const [empleados, setEmpleados] = useState([])
    const [areas, setAreas] = useState([])

    const [mostrarModal, setMostrarModal] = useState(false)
    const [editar, setEditar] = useState(null);

    const mostrarEmpleados = async () => {
        const response = await fetch("https://backendapipdn.azurewebsites.net/obtieneEmpleados/0");
        //debugger;
        if (response.ok) {
            const data = await response.json();
            setEmpleados(data)
        } else {
            Swal.fire(
                'Algo fallo',
                response,
                'error'
            )
        }
    }

    const obtenerareas = async () => {
        const response = await fetch("https://backendapipdn.azurewebsites.net/obtenAreas");
        //debugger;
        if (response.ok) {
            const areas = await response.json();
            debugger;
            setAreas(areas)
        }
    }

    useEffect(() => {
        mostrarEmpleados()
        obtenerareas()
    }, [])

    const guardarEmpleado = async (empleado) => {
        debugger;

        const response = await fetch("https://backendapipdn.azurewebsites.net/ingModEmpleado", {
            method: 'POST',
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(empleado)
        })

        if (response.ok) {
            if (empleado.estatus) {
                setMostrarModal(!mostrarModal);
            }
            Swal.fire(
                'Operacion realizada correctamente',
                response,
                'success'
            )
            mostrarEmpleados();
        } else {
            Swal.fire(
                'Algo fallo',
                response,
                'error'
            )
        }
    }

    return (
        <Container>
            <Row className="mt-4">
                <Col sm="12">
                    <Card>
                        <CardHeader>
                            <h5>Lista de empleados</h5>
                        </CardHeader>
                        <CardBody>
                            <Button size="sm" color="success" onClick={() => setMostrarModal(!mostrarModal)}>Nuevo empleado</Button>
                            <hr></hr>
                            <TablaEmpleados data={empleados}
                                setEditar={setEditar}
                                mostrarModal={mostrarModal}
                                setMostrarModal={setMostrarModal}
                            ></TablaEmpleados>
                        </CardBody>
                    </Card>
                </Col>
            </Row>
            <ModalEmpleado
                mostrarModal={mostrarModal}
                setMostrarModal={setMostrarModal}
                guardarEmpleado={guardarEmpleado}

                areas={areas}

                editar={editar}
                setEditar={setEditar}
                editarContacto={guardarEmpleado}
            >
            </ModalEmpleado>
        </Container>
    )

}

export default App;