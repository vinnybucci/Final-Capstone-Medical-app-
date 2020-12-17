<template>
  <div class="patientOffice-Info"> 
    <h1 class="patientOfficeCardTitle"></h1>
    <router-link v-bind:to="{name: 'patient'}" ><button class="patientHomePageOffice"></button></router-link>
    <router-link v-bind:to="{name: 'writeAReview'}"><button class="patientOfficeInfoOfficeBtn"></button></router-link>
    <router-link v-bind:to="{name: 'patientViewSchedule'}"><button class="viewPatientSchedule"></button></router-link>

    <patient-office-card v-bind:office="office" v-bind:key='office.id' v-for="office in offices">
    <router-link v-bind:to="{name: 'officeInfo', params: {id:office.id}}"></router-link>

    </patient-office-card>
  </div>
</template>

<script>
import patientOfficeCard from '../components/PatientOfficeCard';
import patientService from '../services/PatientService.js';

export default {
  components:{
    patientOfficeCard
  },

  data(){
    return{
      offices: []
    }
  },

  created() {
    patientService.GetAllOffices().then((response) => {
      this.offices = response.data;
    })
  }

}
</script>

<style scoped>

.patientOfficeInfoOfficeBtn{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill4.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:25.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.patientOfficeInfoOfficeBtn:before {
  content: "Write a Review";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.patientOfficeInfoOfficeBtn:after {
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
.patientOfficeInfoOfficeBtn:hover:before {
  top: -50%;
}
.patientOfficeInfoOfficeBtn:hover:after {
  top: 50%;
}

.patientHomePageOffice{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill1.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 35px;
  width: 220px;
  top:20.3%;
  left:10%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;}
      
.patientHomePageOffice:before {
  content: "Patient Home Page";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.patientHomePageOffice:after {
  content: "患者のホームページ";
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
.patientHomePageOffice:hover:before {
  top: -50%;
}
.patientHomePageOffice:hover:after {
  top: 50%;
}

.doctorOffice{
  font-family:"Courier", impact, monospace ;
  margin-top: 60px;
  padding-left:75px;
}

.patientOfficeCardTitle {
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
  width: 710px;
  top:5.9%;
  left:20.2%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.patientOfficeCardTitle:before {
  content: "Office Locations Info";
 
  padding-left:55px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.patientOfficeCardTitle:after {
  content: "オフィスの場所情報";
   padding-top:10px ;
  padding-left:130px ;
  width: 650px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.patientOfficeCardTitle:hover:before {
  top: -50%;
}
.patientOfficeCardTitle:hover:after {
  top: 50%;
}

.patientOffice-Info{
        background-image:url("../img/chansey4.jpg");
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        background-color: #ffcccb;
        padding: 50px;
}

.viewPatientSchedule{
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill3.jpg");
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
.viewPatientSchedule:before {
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
.viewPatientSchedule:after {
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
.viewPatientSchedule:hover:before {
  top: -50%;
}
.viewPatientSchedule:hover:after {
  top: 50%;
}

</style>