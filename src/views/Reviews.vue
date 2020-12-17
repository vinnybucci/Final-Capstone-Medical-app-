<template>
  <div class="reviews-img">
    <router-link v-bind:to="{name: 'patient'}"><button>Home Page</button></router-link>
    <router-link v-bind:to="{name: 'patientOfficeInfo'}"><button>Office Info</button></router-link>
    <select name="office" v-model="officeName">
      <option v-for="office in offices" v-bind:key="office.Id">
        {{office.name}}
      </option></select><br>
      <button type="submit" v-on:click="getReviews()"></button>

    <h1 class="reviewsTitle"></h1>
  <span v-for="review in reviews" v-bind:key="review.id" v-bind:review="review">
  <review-card/>
  </span>
  </div>
</template>

<script>
import reviewCard from '../components/ReviewCard'
import DoctorService from '../services/DoctorService'
export default {
components: {
  reviewCard

},
  data() {
    return {
      reviews: [],
      offices: [],
      officeName: "",
      officeId: ""
    };
  },

  created(){
DoctorService.GetMyOffices(this.$store.state.user.userId).then((response) => {
  this.offices = response.data;
})
  },
  methods: {
    getOfficeIdByName(name){
          let selectedOffices = this.offices.filter(office =>{
              return office.name==name;
          });
          this.officeId = selectedOffices[0].officeId;
      },

      getReviews(){
        DoctorService.GetOfficeReviews(this.officeId).then((response) => {
  this.reviews = response.data;
})
      }
  }
};
</script>

<style scoped>
.reviews-img{
        background-image:url("../img/chansey5.jpg");
        padding: 50px;
       background-size:cover;
        background-attachment: fixed;
        background-repeat: no-repeat;
        height: 945px;
        }
</style>