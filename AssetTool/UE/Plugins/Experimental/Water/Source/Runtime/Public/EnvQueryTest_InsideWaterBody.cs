namespace AssetTool
{
    [JsonAsset("EnvQueryTest_InsideWaterBody")]
    public class UEnvQueryTest_InsideWaterBody : UEnvQueryTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}