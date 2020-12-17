<template>
<div class="review">
<h2>{{review.rating}}</h2>
<h2>{{review.message}}</h2>
<h2>{{review.response}}</h2>

</div>
  
</template>

<script>
export default {

    // props: {
    //     review
    //  }

}
</script>

<style>

.review {
    border: 2px solid black;
    border-radius: 10px;
    width: 275px;
    background-image: linear-gradient(to bottom right, rgb(255, 255, 255), rgb(218, 236, 53));
    background-color: rgb(219, 219, 219);
    height: cover;
    padding: 10px;
    margin: 50px;
    margin-left: 200px;
}

</style>