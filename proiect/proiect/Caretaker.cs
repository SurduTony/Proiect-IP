using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    //Atunci cand un form este inchis, il deschide pe ultimul accesat inaintea celui inchis (push - pop)
    public class FormMemento
    {
        private Form _form;
        public FormMemento(Form form)
        {
            _form = form;
        }
        public Form form { get { return _form; } }
    }

    public class Caretaker
    {
        private Stack<FormMemento> _formMementoStack = new Stack<FormMemento>();
        private FormMemento _formMemento;
        public Caretaker(Form form)
        {
            _formMemento = new FormMemento(form);
        }
        public Form form { set { _formMemento = new FormMemento(value); } }
        //Adaugare memento pe stiva
        public void Save()
        {
            _formMementoStack.Push(_formMemento);
        }
        //Stergere memento de pe stiva
        public Form? Undo()
        {
            if(_formMementoStack.Count > 0)
            {
                var memento = _formMementoStack.Pop();
                return memento.form;
            }
            return null;
        }
    }
}
