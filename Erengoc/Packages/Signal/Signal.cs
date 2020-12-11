namespace Erengoc.Packages.Signal
{
    public class Signal : ISignal
    {
        protected string _hash;

        public string Hash
        {
            get
            {
                if (string.IsNullOrEmpty(this._hash))
                {
                    this._hash = this.GetType().ToString();
                }

                return this._hash;
            }
        }
    }
}