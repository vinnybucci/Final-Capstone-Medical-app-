<template>
  <div class="doctorPage">
    <doctor-buttons/>
   <notifications-list v-if="pending_appointments.length > 0"></notifications-list>
  </div>
</template>

<script>

import doctorButtons from '../components/DoctorButtons.vue';
import NotificationsList from '../components/NotificationsList';
import DoctorService from '../services/DoctorService'

export default {
  components:{
        doctorButtons,
        NotificationsList
  },
  data() {
    return {
      pending_appointments: [],
      appointments: [],
      office: [],
      review: [],
      docDay_office: [],
    };
  },
  methods:{

      getPendingAppointments(){
        return this.appointments.filter((appointment) => {
          return appointment.status == "pending";
        })
      },
      officeInfo(){
          this.$router.push("pathgoeshere");
      },
      reviews(){
          this.$router.push("pathgoeshere");
      },
      schedule(){
          this.$router.push("pathgoeshere");
      }
       
      },

  created(){
    DoctorService.GetAppointments(this.$store.state.user.userId).then((response) => {
      this.appointments = response.data;
      this.pending_appointments = this.getPendingAppointments();
    }).catch((error) => {
      error.status;
    })
  }
};

</script>

<style >
.doctorPage{
        background-image:url("../img/drmario5.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        background-color: #f8ec64;
        padding:25px ;
        height: 1500px;
}
</style>