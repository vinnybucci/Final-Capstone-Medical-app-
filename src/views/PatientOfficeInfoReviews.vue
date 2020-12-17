<template>
  <div class="marioToad">


    <patient-buttons/>
  </div>
</template>

<script>
import patientButtons from '../components/PatientButtons';

export default {
    components:{
        patientButtons
    }
}
</script>

<style>
.marioToad{
        background-image:url("../img/marioToad.jpg");
        background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        background-color: #ecccff;
        padding:25px ;
        height: 1500px;
}
</style>