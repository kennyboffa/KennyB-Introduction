<template>
  <v-main class="main-content">
    <h1>
      Hello there!
    </h1>

    <div class="intro-top">
      <p>
        This is just a simple site I made to introduce myself, and show some of my skills in programming.
        I have built this site using Nuxt.js (with Vue.js, Node.js and vuetify), html and css on the Front-End, and a simple webapi in C# for the Backend with a database in MSSQL.  - Yes,
        a database is a bit overkill for such a simple site, but wanted to show that I have some skills in it! :D
      </p>
    </div>
    <p>
      <br>
      Kenny Boufadene<br>
      Rydstigen 8<br>
      43269 Karl Gustav<br>
      +46737667079<br>
      <a href="mailto: kennyboufadene@gmail.com">kennyboufadene@gmail.com</a><br>
    </p>

    <h3> A little info about me: </h3>
    <br>
    <div>
      <div class="content">
        <p>
          My name is Kenny Boufadene and I am 37 years old soon-to-be programmer and musician, living in the forests just outside of Varberg, Sweden with my wife Catrin and our daughters Decibelle, Celine and Elise.
        </p>
        <p>
          I just finished a 2 month internship at ”Digital Creation” in the city of Varberg, where I developed a web-app where you can make custom quiz walks. I worked with Html, Css, Javascript (Vue.js, Nuxt.js, Node.js and vuetify) and developed a web api with backend in C#, and a database in MSSQL.
          I have earlier in the year had another internship where I worked in React.js (and Material ui) as well as developing a web api in C# and MSSQL for a private care-giver.
        </p>
        <p>
          I am studying to become a software engineer at Campus Varberg, where we mostly learn to code in C# and .NET, with a fullstack focus.
          The education ends in early June of this year. <br><br>
          Link to information about the education (in Swedish):
          <a href="https://campus.varberg.se/yrkeshogskola/systemutvecklare-net">https://campus.varberg.se/yrkeshogskola/systemutvecklare-net</a><br>
        </p>
        <p>
          I have my own music studio ”Studio Meltdown” where I work on music for myself and my bands ”We Are The Catalyst” and ”Manimal”, as well as work with other bands, recording, producing, mixing and mastering. I also shoot and produce music-videos and take band photos.
          I fairly quickly understood that programming was going to be something of a passion for me, as when I started learning it, I felt the same way that I do when I work in the studio, or when I am performing with my bands on stage, being creative and loosing track of time as I get into a ”flow”. I won´t say it´s a natural thing for me to program, but I love doing it, and are not afraid of learning new things!
        </p>
        <br>
        <v-list flat class="list-content">
          <h3>In my education we have had the following courses:</h3>
          <br>
          <v-list-item-group>
            <v-list-item>Developing in C# (Backend)</v-list-item>
            <v-list-item>Agile Development In Teams</v-list-item>
            <v-list-item>Object-Oriented Programming</v-list-item>
            <v-list-item>Database Development And Database Administration</v-list-item>
            <v-list-item>Advanced .NET</v-list-item>
            <v-list-item>Systems Testing</v-list-item>
            <v-list-item>Developing Windows Applications</v-list-item>
            <v-list-item>Developing Webb Applications</v-list-item>
            <v-list-item>Front End Developing</v-list-item>
          </v-list-item-group>
        </v-list>
        <br>
        <p>
          I am often told I am driven, positive, goal-oriented, service-minded, prestigeless, humble, reasonable, responsible, kind and easy to work with.
          In a team I am usually the one that goes the extra mile, have an honest way and someone people feel they can trust. I don´t have far to laughter and have ”the glint in the eye”.
          I don´t seek out conflicts and try to make my workplace a nice place to be!
          I enjoy working both in teams and on my own.
        </p>
        <p>
          When I am not programming I enjoy time with my family. work in my studio, rehearse with my bands, consume good books, movies, games and series (when there is time) or work out in the gym.
        </p>
        <p>
          I hope I sound interesting to you, and I hope you have a good day!
        </p>
        <p>
          Kenny Boufadene
        </p>
      </div>
    </div>
  </v-main>
</template>

<script>
export default {

}
</script>

<style>
.main-content{
    margin:50px;
    text-align:center;
}
.content{
    width: 70%;
    margin: auto;
    text-align: left;
    margin-bottom:20vh;
}
.list-content{
  text-align: center;
}
.intro-top{
  font-style: italic;
  text-align: center;
    margin: auto;
      width: 70%;
  margin-bottom: 5vh;
  margin-top: 5vh;
}

</style>
