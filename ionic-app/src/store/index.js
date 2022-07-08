import { createStore } from 'vuex';

const store = createStore({
    state () {
        return {
            cursos: [
                { id: 1, nombre: "Historia", estudiantes: 6}, 
                { id: 2, nombre: "Inundaciones", estudiantes: 10}, 
                { id: 3, nombre: "Arroyo maldonado", estudiantes: 4}
            ],
        };
    },
    getters: {
        cursos(state) {
            return state.cursos;
        },
        curso(state) {
            return (cursoId) => {
                return state.cursos.find((curso) => curso.id === cursoId);
            };
        },
    },
});

export default store;