<template>
    <div>
      <!--when you're done with that component reference it from routes.js file -->
      <h1>{{msg}}</h1>
     <h3>v-if: Conditional showing</h3>
     <span v-if="5>2"> Can you hide me ?</span>
    <br/>
    <h3>v-html: Bind html to the element</h3>
    <span v-html="newSpan">"newSpan"</span>
    <br/>

     <h3>v-once:Onyl show changes once on the element</h3>
     <span v-once> {{msg}}</span>
    <br/>
    <button @click="Update()">change title</button>
    <br/>
    <h3>v-bind: Bind data to the element</h3>
    <span :class="cssClass">v-bind:class span</span>
    <br/>
    <input type="text" v-model="txtValue">
    Value: {{txtValue}}

  <h3>Bind to N array</h3>
   {{'red'}} <input type="checkbox" name="val1" value="red" v-model="arr">
   <br/> 
   {{'green'}}  <input type="checkbox" name="val2" value="green" v-model="arr">
     <br/>
     <br/>     
     color(s): {{arr}}

    </div>
</template>

<script>
export default {
  data () {
    return {
      msg: 'Directives',
      newSpan: `<span style="color:red;">Span created!</span>`,
      cssClass: 'redCss',
      txtValue: '',
      chkValue: '',
      arr: []
    }
  },
   methods: {
      Update: function() {
        this.msg = "Hello mate";
        this.cssClass = "blueCss";
        this.txtValue = "";
      }
}
}
</script>

<style>
.redCss{
  color:red;
}

.blueCss{
  color: blue;
}

.h1{
  color: blue;
}

</style>
