- To initialize the modules you must call new Engine(modules).Init(), where modules is an array of fullnames of modules you would like to load.
- Every module has an API which can be used by the integration, never use any class of an *.Impl project.
  APIs might contain *.StdImpl namespaces... you are allowed to reference those.
- Each module also has an Impl which is the default implementation of the API. 
  All behaviour of the implementation can be overridden... you do this by registering your own implementation in the ServiceRegistry.

<h1> Naming Conventions </h1>
<p>
	Classes in API projects never have .API in their name only Impl classes do so
</p>

<h1> Modules </h1>
<ul>
	<li> 
		<h2> Items </h2>
		<p> ZEngine.Items.ItemsAPI </p>
		<p> ZEngine.Items.Impl.ItemsImpl </p>
	</li>
</ul>
