<template>
  <div class="appointment-requests">
    
    
    <h1 class="appointmentTitle"></h1>
    <router-link v-bind:to="{name: 'doctor'}"><button class="doctorAppointment" id="doctorAppointmentButton" v-on:click="doctor"></button></router-link>
    <router-link v-bind:to="{name: 'officeInfo'}"><button class="appointmentOffice" v-on:click="officeInfo"></button></router-link>
    <router-link v-bind:to="{name: 'doctorReviews'}"><button class="doctorReviewsQ" v-on:click="doctorReviews"></button></router-link>
    <router-link v-bind:to="{name: 'viewSchedule'}"><button class="appointmentViewSchedule" v-on:click="viewSchedule"></button></router-link>
    
    <appointment-requests-card
      v-bind:appointment="appointment"
      v-bind:key="appointment.appointmentId"
      v-for="appointment in $pendingAppointments"
    >
      <router-link
        v-bind:to="{
          name: 'appointmentRequest',
          params: { id: appointment.appointmentId },
        }"
      ></router-link>
    </appointment-requests-card>

    <appointment-requests-card
      v-bind:office="office"
      v-bind:key="office.id"
      v-for="office in $store.state.officesStatic"
    >
      <router-link
        v-bind:to="{ name: 'officeInfo', params: { id: office.id } }"
      ></router-link>
    </appointment-requests-card>
    <appointmentDoctorCard/>
  </div>
</template>

<script>
import appointmentDoctorCard from "../components/AppointmentDoctorCard";
import doctorService from '../services/DoctorService';

export default {
  components: {
    appointmentDoctorCard
  },

  data() {
    return {
      pendingAppointments: []
    };
  },

  created: {
    pendingAppointments() {
      doctorService.GetAppointments()
      .then((response) => {
        this.pendingAppointments = response.data.filter(appt => {
          return appt.status == 'pending';
        });
      });
    }
  }
};
</script>

<style >


.appointmentTitle {
    font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: linear-gradient(
    to bottom right,
    rgb(255, 255, 255),
    rgb(228, 228, 228)
  );
  height: 60px;
  width: 730px;
  top:5.9%;
  left:20.75%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.appointmentTitle:before {
  content: "Appointment Requests Page";
 
  padding-left:25px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.appointmentTitle:after {
  content: "予約リクエストページ";
   padding-top:10px ;
  padding-left:110px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.appointmentTitle:hover:before {
  top: -50%;
}
.appointmentTitle:hover:after {
  top: 50%;
}

.appointment-requests {
  background-image: url("../img/drmario3.jpg");
  background-size: cover;
  background-attachment: fixed;
  background-repeat: no-repeat;
  padding: 50px;
}

#doctorAppointmentButton {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill3.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:20.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
#doctorAppointmentButton:before {
  content: "Doctor Home Page";
 
  padding-left:1px ;
  width: 250px;
    top:50%;
  left:48%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
#doctorAppointmentButton:after {
  content: "ドクターホームページ";
   padding-top:3px ;
  padding-left:1px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
#doctorAppointmentButton:hover:before {
  top: -50%;
}
#doctorAppointmentButton:hover:after {
  top: 50%;
}
.appointmentOffice{
   font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill7.jpg");
       background-size:105%;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:25.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.appointmentOffice:before {
  content: "Office Info";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.appointmentOffice:after {
  content: "オフィス情報";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.appointmentOffice:hover:before {
  top: -50%;
}
.appointmentOffice:hover:after {
  top: 50%;
}

.doctorReviewsQ{
   font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill4.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:30.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.doctorReviewsQ:before {
  content: "Reviews";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.doctorReviewsQ:after {
  content: "レビュー";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.doctorReviewsQ:hover:before {
  top: -50%;
}
.doctorReviewsQ:hover:after {
  top: 50%;
}

.appointmentViewSchedule{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill1.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:35.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.appointmentViewSchedule:before {
  content: "View Schedule";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.appointmentViewSchedule:after {
  content: "スケジュールを見る";
  padding-left:50px;
  padding-top: 4px;
  width: 250px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.appointmentViewSchedule:hover:before {
  top: -50%;
}
.appointmentViewSchedule:hover:after {
  top: 50%;
}

.appointment-requests{
        background-image:url("../img/drmario3.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        background-color: #63f8db;
        padding:25px ;
        height: 1500px;
}
</style>