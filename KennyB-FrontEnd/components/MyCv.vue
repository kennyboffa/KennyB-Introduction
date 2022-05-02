<template>
  <div class="container">
    <v-progress-circular
      v-if="!loaded"
      class="progress-circle"
      indeterminate
      color="primary"
    />
    <iframe
      v-show="loaded"
      src="https://www.dropbox.com/s/05oyv5lhts0xyho/Kenny%20Boufadene%20CV%202021%20ENG.pdf?raw=1"
      class="cv"
      frameBorder="0"
      scrolling="auto"
      height="500%"
      width="70%"
      @load="load()"
    />
  </div>
</template>

<script>

export default {
  data () {
    return {
      loaded: false

    }
  },

  methods: {
    load () {
      this.loaded = true
    }
  }
}
</script>

<style scoped>
.container{
  align-items: center;
}
.cv{
margin-top:3vh;
height: 200vh;

}
.progress-circle{
    margin-top: 10vh;
}
</style>
