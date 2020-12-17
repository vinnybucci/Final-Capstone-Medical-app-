<template>
<div>
<div v-for="office in offices" v-bind:key="office.id" v-bind:office="office">
   <office-card/>

</div>
</div>

</template>

<script>
import PatientService from '../services/PatientService'
import officeCard from '../components/OfficeCard'
export default {
    components: {
        officeCard
    },

data(){
    return{
        offices: []
    }
},

created(){
    PatientService.GetDoctorsOffices(this.router.params).then((response) => {
        this.offices = response.data;
    })
}

}
</script>

<style >

</style>