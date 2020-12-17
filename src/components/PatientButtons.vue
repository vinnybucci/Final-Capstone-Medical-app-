<template>
  <div>
    <h1 class="patientHomePageTitle"></h1>
    <router-link v-bind:to="{name: 'writeAReview'}" ><button class="patientWriteReview"></button></router-link>
    <router-link v-bind:to="{name: 'patientOfficeInfo'}"><button class="patientOfficeInfoBtn"></button></router-link>
    <router-link v-bind:to="{name: 'patientViewSchedule'}"><button class="viewPatientSchedule"></button></router-link>
    
  </div>
</template>

<script>
export default {

}
</script>
 
<style >
.patientWriteReview{
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
      
.patientWriteReview:before {
  content: "Write A Review";
  padding-top: 2px;
  padding-left:4px ;
  width: 250px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.patientWriteReview:after {
  content: "レビューを書く";
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
.patientWriteReview:hover:before {
  top: -50%;
}
.patientWriteReview:hover:after {
  top: 50%;
}

.patientOfficeInfoBtn{
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
.patientOfficeInfoBtn:before {
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
.patientOfficeInfoBtn:after {
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
.patientOfficeInfoBtn:hover:before {
  top: -50%;
}
.patientOfficeInfoBtn:hover:after {
  top: 50%;
}

.patientHomePageTitle {
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
  top:10.5%;
  left:22.8%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.patientHomePageTitle:before {
  content: "Patient Home Page";
  padding-left:25px ;
  width: 650px;
    top:50%;
  left:63%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.patientHomePageTitle:after {
  content: "患者のホームページ";
   padding-top:10px ;
  padding-left:110px ;
  width: 650px;
    top:50%;
  left:53.5%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.patientHomePageTitle:hover:before {
  top: -50%;
}
.patientHomePageTitle:hover:after {
  top: 50%;
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