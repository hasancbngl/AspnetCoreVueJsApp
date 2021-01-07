<template>
    <div>
      <h1>{{msg}}</h1>
       <br/>
       
         <h1>Parent route component </h1>
         Your current route is: {{routeValue}}
         

    </div>
</template>

<script>
export default {
  data () {
    return {
      msg: 'Routes Example',
      routeValue: ''
    }
  },
  methods: {
      Update: function() {
      
      }
  }
}
</script>

<style>
h1{
  color: green;
}

</style>
