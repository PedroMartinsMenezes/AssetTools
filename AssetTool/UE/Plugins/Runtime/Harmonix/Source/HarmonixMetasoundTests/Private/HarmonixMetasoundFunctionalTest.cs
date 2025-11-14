namespace AssetTool
{
    [JsonAsset("HarmonixMetasoundFunctionalTestLibrary")]
    public class UHarmonixMetasoundFunctionalTestLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixMetasoundFunctionalTest")]
    public class AHarmonixMetasoundFunctionalTest : AFunctionalTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}