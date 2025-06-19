namespace AssetTool
{
    [JsonAsset("EnvQueryGenerator_OnCircle")]
    public class UEnvQueryGenerator_OnCircle : UEnvQueryGenerator_ProjectedPoints
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}