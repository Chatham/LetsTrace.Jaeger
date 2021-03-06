using LetsTrace.Samplers.HTTP;

namespace LetsTrace.Jaeger.Samplers.Http
{
    public static class ProbabilisticSamplingStrategyMarshaller
    {
        public static ProbabilisticSamplingStrategy FromThrift(this global::Jaeger.Thrift.Agent.ProbabilisticSamplingStrategy thriftInstance)
        {
            return new ProbabilisticSamplingStrategy
            {
                SamplingRate = thriftInstance.SamplingRate
            };
        }
    }
}