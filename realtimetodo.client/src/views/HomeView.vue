<template>
  <div class="home">
    <h1>To DO List</h1>
    <br />
    <table>
      <thead>
        <tr>
          <th>List Name</th>
          <th>Peddings</th>
          <th>Completed</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="l in lists" :key="l.id">
          <td>
            <router-link :to="{name:'list', params:{listId: l.id}}"> 
              {{l.listName}} 
            </router-link>
            </td>
          <td>{{l.completed}}</td>
          <td>{{l.pending}}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';


@Component
export default class HomeView extends Vue {
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  lists: any[] = [];

  demoList(){
    this.lists.push({id: 0, listName:"Foo", completed:5, pending: 10});
    this.lists.push({id: 1, listName:"bar", completed:5, pending: 10});
    this.lists.push({id: 2, listName:"Foo", completed:5, pending: 10});
    this.lists.push({id: 3, listName:"Foo", completed:5, pending: 10});
  }
  created(){
    this.demoList();
  }
}
</script>
