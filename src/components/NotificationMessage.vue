<template>
  <div v-if="show" class="alert alert-success alert-dismissible fade show" role="alert">
      <button v-on:click="show = false" type="button" class="close" data-dismiss="alert" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
        You have a new appointment!
</div>
</template>

<script>
export default {

  data(){
    return{
      show: true
    }
  }

}
</script>

<style>

</style>