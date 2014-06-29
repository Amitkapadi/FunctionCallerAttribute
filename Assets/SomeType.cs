using UnityEngine;
using System.Collections;


public class SomeType : MonoBehaviour
{
	[FunctionCallerAttribute( "Do Stuff Now" )]
	public void doStuff()
	{
		Debug.Log( "doStuff called" );
	}


	[FunctionCallerAttribute( "Do More Stuff With Param" )]
	public void doMoreStuff( int param, string otherParam )
	{
		Debug.Log( "doMoreStuff called with (int): " + param + ", (string)" + otherParam );
	}
}
