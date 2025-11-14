namespace AssetTool
{
    [JsonAsset("InputTrigger")]
    public class UInputTrigger : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerTimedBase")]
    public class UInputTriggerTimedBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerDown")]
    public class UInputTriggerDown : UInputTrigger
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerPressed")]
    public class UInputTriggerPressed : UInputTrigger
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerReleased")]
    public class UInputTriggerReleased : UInputTrigger
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerHold")]
    public class UInputTriggerHold : UInputTriggerTimedBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerHoldAndRelease")]
    public class UInputTriggerHoldAndRelease : UInputTriggerTimedBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerTap")]
    public class UInputTriggerTap : UInputTriggerTimedBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerPulse")]
    public class UInputTriggerPulse : UInputTriggerTimedBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerChordAction")]
    public class UInputTriggerChordAction : UInputTrigger
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerChordBlocker")]
    public class UInputTriggerChordBlocker : UInputTriggerChordAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputTriggerCombo")]
    public class UInputTriggerCombo : UInputTrigger
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}