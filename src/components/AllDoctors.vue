<template>
<div>
<div v-for="doctor in doctors" v-bind:key="doctor.userId">

<router-link v-bind:to="{name : 'doctorsOffices', params:{id: doctor.userId}}"> {{doctor.name}} </router-link>   

</div>
</div>
</template>

<script>
import patientService from "../services/PatientService"
export default {

data(){
    return{
        doctors: []
    }
},

created(){
patientService.GetVerifiedDoctors().then((response) => {
    this.doctors = response.data;
})
}



}

</script>



<style >

</style>