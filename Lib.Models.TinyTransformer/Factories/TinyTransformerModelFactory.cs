using Lib.Models.TinyTransformer.Configuration;
using Lib.Models.TinyTransformer.State;

namespace Lib.Models.TinyTransformer.Factories
{
    public class TinyTransformerModelFactory
    {
        public TinyTransformerModel Create(TinyTransformerConfig config, TinyTransformerWeights weights)
        {
            return new TinyTransformerModel(config, weights);
        }
    }
}