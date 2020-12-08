<template>
  <div class="home">
      <h1>Home</h1>
      <div v-for="doctor in doctors" v-bind:key="doctor.id">
          {{doctor.username}}
      </div>
  </div>
</template>

<script>
import authService from '../services/AuthService';

export default {
    data() {
        return {
            doctors: []
        }
    },
    created() {
        authService.getPendingDoctors()
        .then(response => {
            this.doctors=response.data;
        })
    }
}
</script>

<style>

</style>