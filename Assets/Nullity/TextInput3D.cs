using UnityEngine;
namespace nullity
{
    public class TextInput3D : Text3D
    {
        private string _textinput;
        private bool _active;
		private string _text{set=>_textmesh.text=value;}
        public new string Text{get=>_textinput;}
        public TextInput3D(string name,int size,string font,Color color) : base(name,"",size,font,color)
        {
			_textinput="";
			_text="";
        }
        public void reset()
        {
		    _textinput = "";
			_text="";
        }
		public new void SetActive(bool state)
		{
			if(state) _text = _textinput+"_";
			else _text = _textinput;
			_active=state;
		}
        public void Update()
        {
            if(_active)
            {	
                foreach (char c in Input.inputString)
                {
                    if (c == '\b') // has backspace/delete been pressed?
                    {
                        if (_textinput.Length > 0)
                        {
                            _textinput = _textinput.Substring(0, _textinput.Length - 1);
                            _text = _textinput+"_";
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
                        _text = _textinput+"_";
                    }
                }
            }
        }
    }   

}

	// //private bool ifEnter=false;
	// 	private string _textinput="";
	// 	public string getText{get=>_textinput;}
	// 	private bool _active;
	// 	public TextInputObject(string name,int size,string font,nullity.Color color) : base(name,"",size,font,color)
	// 	{
			
	// 	}
	// 	public void reset()
	// 	{
	// 		_textinput = "";
	// 		Text="";
	// 	}
	// 	public new void SetActive(bool state)
	// 	{
	// 		if(state) Text = _textinput+"_";
	// 		else Text = _textinput;
	// 		_active=state;
	// 	}
	// 	public void update()
	// 	{
	// 		if(_active)
	// 		{
	// 			foreach (char c in Input.inputString)
	// 			{
	// 				if (c == '\b') // has backspace/delete been pressed?
	// 				{
	// 					if (_textinput.Length != 0)
	// 					{
	// 						_textinput = _textinput.Substring(0, _textinput.Length - 1);
	// 						Text = _textinput+"_";
	// 					}
	// 				}
	// 				else if ((c == '\n') || (c == '\r')) // enter/return
	// 				{
	// 					//ifEnter=true;
	// 					//print("User entered their name: " + Text);
	// 				}
	// 				else
	// 				{
	// 					_textinput += c;
	// 					Text = _textinput+"_";
	// 				}
	// 			}
	// 		}
	// 	}
		