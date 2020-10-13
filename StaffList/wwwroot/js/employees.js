var app = new Vue({
    el: '#app',
    data: {

        editing: false,
        loading: false,
        objectIndex: 0,
        employeeModel: {
            id: 0,
            fullName: "Full name",
            position: "Position",
            birthday: new Date(),
            description: "description",
            maternityLeave: false
        },
        employees: [],

    },
    mounted() {
        this.getEmployees();
    },
    methods: {
        getEmployees() {
            this.loading = true;
            axios.get('/Employees/employees')
                .then(res => {
                    console.log(res);
                    this.employees = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });

        },
        createEmployee() {
            this.loading = true;
            axios.post("/Employees/employee", this.employeeModel)
                .then(res => {
                    console.log(res.data);
                    this.employees.push(res.data)
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        newEmployee() {
            this.editing = true;
            this.employeeModel.id = 0;
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
    }
});