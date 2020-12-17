<template>
<div class="allDoctorPatient">
  <all-doctors/>
  </div>
</template>

<script>
import AllDoctors from '../components/AllDoctors'
export default {
    components: {
        AllDoctors
    }

}
</script>

<style >
.allDoctorPatient{
        background-image:url("../img/chansey3.jpg");
        padding: 50px;
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        height: 945px;
        }
</style>