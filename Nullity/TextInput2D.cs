namespace nullity
{
    public class TextInput2D: Text2D
	{
	
		private string _textinput;
		private bool _active;
		public TextInput2D(string name,int x,int y,int size=12):base(name,x,y,"_",size)
		{
			_textinput="";
			_active=false;
		}
		public TextInput2D(string name,int x,int y,string font,int size=12):base(name,x,y,"_",font,size)
		{
			_textinput="";
			_active=false;
		}
		public void Reset()
		{
			_textinput="";
			Text = "";
		}
		public void SetInput(bool state)
		{
			if(state) Text = _textinput+"_";
			else Text = _textinput;
			_active=state;
		}
		public void Update()
		{
			if(_active)
			{
				foreach (char c in UnityEngine.Input.inputString)
				{
					if (c == '\b') // has backspace/delete been pressed?
					{
						if (_textinput.Length != 0)
						{
							_textinput = _textinput.Substring(0, _textinput.Length - 1);
							Text = _textinput+"_";
						}
					}
					else if ((c == '\n') || (c == '\r')) // enter/return
					{
						//ifEnter=true;
						//print("User entered their name: " + Text);
					}
					else
					{
						_textinput += c;
						Text = _textinput+"_";
					}
				}
			}
		}
	}
		//private bool ifEnter=false;
		// private string _textinput="";
		// public string getText{get=>_textinput;}
		// private bool _active;
        // public bool Active{get=>_active;}
		// public TextInput(string name,int size,string font,nullity.Color color) : base(name,"",size,font,color)
		// {
			
		// }
		// public void reset()
		// {
		// 	_textinput = "";
		// 	Txt="";
		// }
		// public new void SetActive(bool state)
		// {
		// 	if(state) Txt = _textinput+"_";
		// 	else Txt = _textinput;
		// 	_active=state;
		// }
		// public void update()
		// {
		// 	if(_active)
		// 	{
		// 		foreach (char c in UnityEngine.Input.inputString)
		// 		{
		// 			if (c == '\b') // has backspace/delete been pressed?
		// 			{
		// 				if (_textinput.Length != 0)
		// 				{
		// 					_textinput = _textinput.Substring(0, _textinput.Length - 1);
		// 					Txt = _textinput+"_";
		// 				}
		// 			}
		// 			else if ((c == '\n') || (c == '\r')) // enter/return
		// 			{
		// 				//ifEnter=true;
		// 				//print("User entered their name: " + Text);
		// 			}
		// 			else
		// 			{
		// 				_textinput += c;
		// 				Txt = _textinput+"_";
		// 			}
		// 		}
		// 	}
		// }
    
}