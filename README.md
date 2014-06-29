FunctionCallerAttribute
=======================

Unity function caller attribute example. Lets you call functions with or without parameters from the inspector. See demo scene for example.


Basic Usage
-----

- on the class that you want to be able to call functions, decorate each function with the FunctionCallerAttribute.
- create a CustomEditor for your class with nothing more than OnInspectorGUI in it that calls through to base.OnInspectorGUI()
- that's it. Now you will see in the inspector your methods will each have a button to call them. Note that this demo only provides a UI for int and string parameters. You can easily extend it to add any other parameters that you may want to use.