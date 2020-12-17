<template>
<div>
    

    <div class="appointmentCard">
       
          <!-- user name: {{appointment.patientUserName}}<br/> -->
          First Name: {{appointment.patientFirstName}}<br/>
          Last Name: {{appointment.patientLastName}}<br/>
          Phone Number: {{appointment.patientPhone}}<br/>
          Email: {{appointment.patientEmail}}<br/>
          Date of Birth: {{appointment.patientDoB}}<br/>
          <br/>
          <p><b>Appointment Info</b></p>
          Date: {{appointment.date}}<br/>
          Time: {{appointment.time}}<br/>
          virtual: {{appointment.virtual}}<br/>
          Message: {{appointment.message}}<br/>
          Status: {{appointment.status}}<br/>

        <button class="setToApproveAppt" type="submit" v-if="appointment.status == 'Pending'" v-on:click="appointment.status ='Approved';ChangeAppointmentStatus(appointment)">Approve Appointment</button> 
          
    </div>


</div>
</template>

<script>
import doctorServive from '../services/DoctorService';

export default {
    props: {
        appointment: Object,
    },

    methods: {
        ChangeAppointmentStatus(appointment) {
            doctorServive.RespondToPendingAppointment(appointment).then((response) => {
                if (response.status === 200 || response.status === 201) {
                    alert("Appointment status has successfully changed.");
                }
            })
        }
    } 
}
</script>



<style >
.appointmentCard {

    border: 2px solid black;
    border-radius: 10px;
    width: 275px;
    background-image: linear-gradient(to bottom right, rgb(255, 255, 255), rgb(218, 236, 53));
    height: cover;
    padding: 10px;
    margin: 50px;
    margin-left: 250px;
}

.appointmentTitle {
  margin: 50px;
}

</style>