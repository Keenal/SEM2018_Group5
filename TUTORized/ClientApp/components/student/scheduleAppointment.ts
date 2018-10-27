import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import $ from 'jquery';
import { Appointment } from '../../models/Appointment';
import StudentService from '../../services/student/studentServices';

@Component
export default class ScheduleAppointment extends Vue {
    appointment = new Appointment(); 
    id: string = '';

    appointments: Array<Appointment> = [];
    event = new Appointment();
    selectedEvent = new Appointment();
    isLoaded: boolean = false;

    submitFunction() {

        $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            type: "POST",
            url: 'api/Student/makeStudentAppointment',
            data: JSON.stringify({
                "id": this.appointment.id
            }),
            dataType: 'json',
            complete: function (response) {
                alert("Scheduled Successfully");
            }
        });
    }
    
    itemText(appointment: Appointment) {
        console.log(appointment);
        return appointment.tutorFirstName + appointment.studentLastName + appointment.date
    }
    mounted() {
        StudentService.GetListOfAllAvailableAppointments().then(result => {
            this.appointments = result;
            this.isLoaded = true;
        });
    }
}

import { ComponentOptions } from 'Vue';

export declare type VueClass = {
    new(): Vue;
} & typeof Vue;
export declare type DecoratedClass = VueClass & {
    __decorators__?: ((options: ComponentOptions<Vue>) => void)[];
};




/*import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import { User } from '../../models/User';
import StudentService from '../../services/student/studentServices';

@Component
export default class ScheduleAppointment extends Vue {

    tutors: Array<User> = [];
    tutor = new User();
    selectedTutor = new User();
    isLoaded: boolean = false;

    mounted() {
        StudentService.getListOfTutors().then(result => {
            this.tutors = result;
            this.isLoaded = true;
        });
    }
}
*/