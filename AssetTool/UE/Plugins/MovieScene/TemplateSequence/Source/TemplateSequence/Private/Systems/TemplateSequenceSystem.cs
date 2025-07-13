namespace AssetTool
{
    [JsonAsset("TemplateSequenceSystem")]
    public class UTemplateSequenceSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TemplateSequencePropertyScalingInstantiatorSystem")]
    public class UTemplateSequencePropertyScalingInstantiatorSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TemplateSequencePropertyScalingEvaluatorSystem")]
    public class UTemplateSequencePropertyScalingEvaluatorSystem : UMovieSceneEntitySystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}