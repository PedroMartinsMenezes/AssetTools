namespace AssetTool
{
    [JsonAsset("HarmonixFunctionalTestAction")]
    public class UHarmonixFunctionalTestAction : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionSequence")]
    public class UHarmonixFunctionalTestActionSequence : UHarmonixFunctionalTestAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionParallel")]
    public class UHarmonixFunctionalTestActionParallel : UHarmonixFunctionalTestAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionDelay")]
    public class UHarmonixFunctionalTestActionDelay : UHarmonixFunctionalTestAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionWaitForTimeout")]
    public class UHarmonixFunctionalTestActionWaitForTimeout : UHarmonixFunctionalTestAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixFunctionalTestActionFinishTest")]
    public class UHarmonixFunctionalTestActionFinishTest : UHarmonixFunctionalTestAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}