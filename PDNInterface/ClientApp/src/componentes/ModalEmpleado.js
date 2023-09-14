import { useEffect, useState } from "react"
import Swal from 'sweetalert2'

import { Form, FormGroup, Modal, ModalBody, ModalHeader, Label, Input, ModalFooter, Button } from "reactstrap"

const modeloEmpleado = {
    idEmpleado: 0,
    nombre: "",
    apaterno: "",
    amaterno: "",
    area: 1,
    fechaNacimiento: "",
    sueldo: 0,
    fechaCreacion: "",
    estatus: true,
}

const ModalEmpleado = ({ mostrarModal, setMostrarModal, guardarEmpleado, editar, setEditar, areas }) => {

    const [empleado, setEmpleado] = useState(modeloEmpleado);
    
    const actualizarDato = (e) => {
        //console.log(e.target.name + ":" + e.target.value)
        debugger;

        setEmpleado({

            ...empleado,
            [e.target.name]: e.target.value
        }
        )
    }

    function validacion() {
        if (empleado.nombre !== "" && empleado.apaterno !== "" && empleado.fechaNacimiento !== "") {
            return true;
        } else {
            return false
        }
    }

    const enviarDatos = () => {
        debugger;
        if (validacion()) {
            empleado.fechaCreacion = empleado.fechaNacimiento;
            guardarEmpleado(empleado)
        } else {
            Swal.fire(
                'Faltan datos',
                'Por favor revisa que todos los campos tengan un valor válido',
                'error'
            )
        }

    }

    useEffect(() => {
        debugger;
        if (editar != null) {
            editar.fechaNacimiento = new Date(editar.fechaNacimiento).toISOString().slice(0, 10);
            debugger;
            setEmpleado(editar)
            if (!editar.estatus) {
                guardarEmpleado(editar)
                setEmpleado(modeloEmpleado)

            }
        } else {
            setEmpleado(modeloEmpleado)
        }
    }, [editar])

    const cerrarModal = () => {
        setEmpleado(modeloEmpleado)
        setMostrarModal(!mostrarModal)
        setEditar = null;
    }


    return (
        <Modal isOpen={mostrarModal}>
            <ModalHeader>
                {empleado.IdEmpleado === 0 ? "Agregar Empleado" : "Editar Empleado"}
            </ModalHeader>
            <ModalBody>
                <Form>
                    <FormGroup>
                        <Label for="nombre">
                            Nombre
                        </Label>
                        <Input name="nombre" id="nombre" onChange={(e) => actualizarDato(e)} value={empleado.nombre} />
                        <Label for="apaterno">
                            Apellido paterno
                        </Label>
                        <Input name="apaterno" id="apaterno" onChange={(e) => actualizarDato(e)} value={empleado.apaterno} />
                        <Label for="amaterno">
                            Apellido Materno
                        </Label>
                        <Input name="amaterno" id="amaterno" onChange={(e) => actualizarDato(e)} value={empleado.amaterno} />
                        <Label for="area">
                            Area
                        </Label>
                        {/*<Input name="area" id="area" onChange={(e) => actualizarDato(e)} value={empleado.area} />*/}
                        <select class="form-control" name="area" id="area" value={empleado.area} onChange={(e) => actualizarDato(e)}
                        >
                            {areas.map((area)=>(
                                <option key={area.idArea} value={area.idArea}>
                                    {area.area}
                            </option>
                            ))}
                        </select>
                        <Label for="fechaNac">
                            Fecha de Nacimiento
                        </Label>

                        <Input class="form-control" type="date" id="fechaNac" name="fechaNacimiento" onChange={(e) => actualizarDato(e)} value={empleado.fechaNacimiento} />
                        <Label for="sueldo">
                            Sueldo
                        </Label>
                        <Input name="sueldo" id="sueldo" onChange={(e) => actualizarDato(e)} value={empleado.sueldo} />
                    </FormGroup>
                </Form>
            </ModalBody>
            <ModalFooter>
                <Button color="danger" size="sm" onClick={cerrarModal}>Cancelar</Button>
                <Button color="primary" size="sm" onClick={enviarDatos}>Guardar</Button>
            </ModalFooter>
        </Modal>
    )
}

export default ModalEmpleado;