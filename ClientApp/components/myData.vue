<template>
    <div>
      <h1>{{msg}}</h1>
       <br/>
      <h3>Contains the properties used through the component</h3>
      <span>Can be accessed via interpolation: {{simple}}</span>
      <br/>
         <h3>Contains the properties used methods</h3>
      <span>here is some value: {{value}}</span>
      <br/>
      <span>Number: {{complex.myNumber}}</span>
      <button @click="Update()"> Increase</button>
         <br/>
         <h4>Info</h4>
         Name:{{coder.name}} <br/>
         Age:{{coder.age}}

         

    </div>
</template>

<script>
export default {
  data () {
    return {
      msg: 'My Data is update',
      simple: `Simple Text`,
      value: '0',
      complex: {
          myNumber:5
      },
      coder: {
          name: 'hasan',
          age:23
      }
    }
  },
  methods: {
      Update: function(e) {
          this.value = 'value updated';
          this.complex.myNumber = this.complex.myNumber +1;
      }
  }
}
</script>

<style>
h1{
  color: blue;
}

</style>
