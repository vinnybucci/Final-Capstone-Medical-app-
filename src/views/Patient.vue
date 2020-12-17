<template>
<div class='patient'>
    <patient-buttons/>
    <appointment-form/>
</div>
</template>

<script>
import appointmentForm from '../components/AppointmentForm';
import patientButtons from '../components/PatientButtons';

export default {
    components:{
        appointmentForm,
        patientButtons
    }

}
</script>

<style >
.patient{
        background-image:url("../img/chansey.jpg");
        padding: 50px;
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        background-color: #ccfeff;
        height: 1100px;
        }
</style>