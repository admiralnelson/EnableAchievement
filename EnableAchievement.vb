Imports System.Reflection
Imports HarmonyLib
Imports StoryMode
Imports StoryMode.GameComponents.CampaignBehaviors
Imports TaleWorlds.CampaignSystem
Imports TaleWorlds.CampaignSystem.Actions
Imports TaleWorlds.CampaignSystem.Actions.ChangeOwnerOfSettlementAction
Imports TaleWorlds.CampaignSystem.Actions.KillCharacterAction
Imports TaleWorlds.CampaignSystem.Election
Imports TaleWorlds.CampaignSystem.Issues
Imports TaleWorlds.CampaignSystem.MapEvents
Imports TaleWorlds.CampaignSystem.Party
Imports TaleWorlds.CampaignSystem.Settlements
Imports TaleWorlds.CampaignSystem.Settlements.Buildings
Imports TaleWorlds.CampaignSystem.Settlements.Workshops
Imports TaleWorlds.Core
Imports TaleWorlds.Library

Public Module BunchOfDelegates
    Public Function CacheHighestSkillValue(target As AchievementsCampaignBehavior) As Action
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("CacheHighestSkillValue", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action), target)
    End Function
    Public Function ProgressOwnedWorkshopCount(target As AchievementsCampaignBehavior) As Action(Of Workshop, Hero)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("ProgressOwnedWorkshopCount", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Workshop, Hero)), target)
    End Function
    Public Function ProgressOwnedCaravanCount(target As AchievementsCampaignBehavior) As Action(Of MobileParty)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("ProgressOwnedCaravanCount", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of MobileParty)), target)
    End Function
    Public Function OnSettlementOwnerChanged(target As AchievementsCampaignBehavior) As Action(Of Settlement, Boolean, Hero, Hero, Hero, ChangeOwnerOfSettlementDetail)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnSettlementOwnerChanged", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Settlement, Boolean, Hero, Hero, Hero, ChangeOwnerOfSettlementDetail)), target)
    End Function
    Public Function ProgressCreatedKingdomCount(target As AchievementsCampaignBehavior) As Action(Of Kingdom)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("ProgressCreatedKingdomCount", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Kingdom)), target)
    End Function
    Public Function OnHeroKilled(target As AchievementsCampaignBehavior) As Action(Of Hero, Hero, KillCharacterActionDetail, Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnHeroKilled", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Hero, Hero, KillCharacterActionDetail, Boolean)), target)
    End Function
    Public Function OnBeforeHeroKilled(target As AchievementsCampaignBehavior) As Action(Of Hero, Hero, KillCharacterActionDetail, Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnBeforeHeroKilled", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Hero, Hero, KillCharacterActionDetail, Boolean)), target)
    End Function
    Public Function ProgressClanTier(target As AchievementsCampaignBehavior) As Action(Of Clan, Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("ProgressClanTier", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Clan, Boolean)), target)
    End Function
    Public Function OnHideoutBattleCompleted(target As AchievementsCampaignBehavior) As Action(Of BattleSideEnum, HideoutEventComponent)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnHideoutBattleCompleted", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of BattleSideEnum, HideoutEventComponent)), target)
    End Function
    Public Function ProgressHeroSkillValue(target As AchievementsCampaignBehavior) As Action(Of Hero, SkillObject, Integer, Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("ProgressHeroSkillValue", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Hero, SkillObject, Integer, Boolean)), target)
    End Function
    Public Function PlayerInventoryExchange(target As AchievementsCampaignBehavior) As Action(Of List(Of ValueTuple(Of ItemRosterElement, Integer)), List(Of ValueTuple(Of ItemRosterElement, Integer)), Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("PlayerInventoryExchange", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of List(Of ValueTuple(Of ItemRosterElement, Integer)), List(Of ValueTuple(Of ItemRosterElement, Integer)), Boolean)), target)
    End Function
    Public Function OnTournamentFinish(target As AchievementsCampaignBehavior) As Action(Of CharacterObject, MBReadOnlyList(Of CharacterObject), Town, ItemObject)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnTournamentFinish", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of CharacterObject, MBReadOnlyList(Of CharacterObject), Town, ItemObject)), target)
    End Function
    Public Function OnSiegeCompleted(target As AchievementsCampaignBehavior) As Action(Of Settlement, MobileParty, Boolean, MapEvent.BattleTypes)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnSiegeCompleted", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Settlement, MobileParty, Boolean, MapEvent.BattleTypes)), target)
    End Function
    Public Function OnMapEventEnded(target As AchievementsCampaignBehavior) As Action(Of MapEvent)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnMapEventEnded", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of MapEvent)), target)
    End Function
    Public Function OnQuestCompleted(target As AchievementsCampaignBehavior) As Action(Of QuestBase, QuestBase.QuestCompleteDetails)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnQuestCompleted", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of QuestBase, QuestBase.QuestCompleteDetails)), target)
    End Function
    Public Function OnBuildingLevelChanged(target As AchievementsCampaignBehavior) As Action(Of Town, Building, Integer)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnBuildingLevelChanged", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Town, Building, Integer)), target)
    End Function
    Public Function OnNewItemCrafted(target As AchievementsCampaignBehavior) As Action(Of ItemObject, ItemModifier, Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnNewItemCrafted", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of ItemObject, ItemModifier, Boolean)), target)
    End Function
    Public Function OnClanChangedKingdom(target As AchievementsCampaignBehavior) As Action(Of Clan, Kingdom, Kingdom, ChangeKingdomAction.ChangeKingdomActionDetail, Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnClanChangedKingdom", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Clan, Kingdom, Kingdom, ChangeKingdomAction.ChangeKingdomActionDetail, Boolean)), target)
    End Function
    Public Function OnClanDestroyed(target As AchievementsCampaignBehavior) As Action(Of Clan)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnClanDestroyed", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Clan)), target)
    End Function
    Public Function ProgressTotalTradeProfit(target As AchievementsCampaignBehavior) As Action(Of Integer)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("ProgressTotalTradeProfit", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Integer)), target)
    End Function
    Public Function OnDailyTick(target As AchievementsCampaignBehavior) As Action
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnDailyTick", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action), target)
    End Function
    Public Function CheckHeroMarriage(target As AchievementsCampaignBehavior) As Action(Of Hero, Hero, Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("CheckHeroMarriage", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Hero, Hero, Boolean)), target)
    End Function
    Public Function CheckKingdomDecisionConcluded(target As AchievementsCampaignBehavior) As Action(Of KingdomDecision, DecisionOutcome, Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("CheckKingdomDecisionConcluded", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of KingdomDecision, DecisionOutcome, Boolean)), target)
    End Function
    Public Function OnMissionStarted(target As AchievementsCampaignBehavior) As Action(Of IMission)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnMissionStarted", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of IMission)), target)
    End Function
    Public Function OnSettlementEnter(target As AchievementsCampaignBehavior) As Action(Of MobileParty, Settlement, Hero)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnSettlementEnter", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of MobileParty, Settlement, Hero)), target)
    End Function
    Public Function OnNewGameCreatedPartialFollowUpEnd(target As AchievementsCampaignBehavior) As Action(Of CampaignGameStarter)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnNewGameCreatedPartialFollowUpEnd", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of CampaignGameStarter)), target)
    End Function
    Public Function OnGameLoadFinished(target As AchievementsCampaignBehavior) As Action
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnGameLoadFinished", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action), target)
    End Function
    Public Function OnHeroCreated(target As AchievementsCampaignBehavior) As Action(Of Hero, Boolean)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnHeroCreated", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Hero, Boolean)), target)
    End Function
    Public Function OnIssueUpdated(target As AchievementsCampaignBehavior) As Action(Of IssueBase, IssueBase.IssueUpdateDetails, Hero)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnIssueUpdated", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of IssueBase, IssueBase.IssueUpdateDetails, Hero)), target)
    End Function
    Public Function OnRulingClanChanged(target As AchievementsCampaignBehavior) As Action(Of Kingdom, Clan)
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnRulingClanChanged", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action(Of Kingdom, Clan)), target)
    End Function
    Public Function CheckTutorialFinished(target As AchievementsCampaignBehavior) As Action
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("CheckTutorialFinished", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action), target)
    End Function
    Public Function ProgressAssembledDragonBanner(target As AchievementsCampaignBehavior) As Action
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("ProgressAssembledDragonBanner", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action), target)
    End Function
    Public Function OnConfigChanged(target As AchievementsCampaignBehavior) As Action
        Dim theType = GetType(AchievementsCampaignBehavior)
        Dim theMethod = theType.GetMethod("OnConfigChanged", BindingFlags.NonPublic Or BindingFlags.Instance)
        If IsNothing(theMethod) Then Throw New KeyNotFoundException
        Return theMethod.CreateDelegate(GetType(Action), target)
    End Function
End Module

Public Module EnableAchievement
    Public Sub DoIt(gameStarterObject As IGameStarter)
        Try
            Dim campaignStarter = CType(gameStarterObject, CampaignGameStarter)
            Dim achievementManagerBehaviour = campaignStarter.CampaignBehaviors.Where(Function(x) x.StringId.Contains("AchievementsCampaignBehavior")).FirstOrDefault()
            If IsNothing(achievementManagerBehaviour) Then
                campaignStarter.AddBehavior(New AchievementsCampaignBehavior())
            End If
            Task.Delay(1000 * 1).ContinueWith(
                Sub()
                    Dim theType = GetType(AchievementsCampaignBehavior)
                    Dim deactivateAchievements = theType.GetProperty("_deactivateAchievements", BindingFlags.NonPublic Or BindingFlags.Instance)
                    If IsNothing(deactivateAchievements) Then Exit Sub
                    deactivateAchievements.SetValue(achievementManagerBehaviour, False)
                End Sub)
        Catch ex As InvalidCastException
            Print("achievement enabler: there's no achievement in custom battle :^)")
        End Try
    End Sub
    <HarmonyPatch(GetType(AchievementsCampaignBehavior), "CheckAchievementSystemActivity")>
    Public Class CheckAchievementSystemActivity
        Public Shared Function Prefix(ByRef __result As Boolean) As Boolean
            __result = True
            Return False
        End Function
    End Class

    <HarmonyPatch(GetType(AchievementsCampaignBehavior), "RegisterEvents")>
    Public Class RegisterEvents
        Public Shared Function Prefix(ByRef __instance As AchievementsCampaignBehavior) As Boolean
            Dim this = __instance
            CampaignEvents.OnCharacterCreationIsOverEvent.AddNonSerializedListener(this, CacheHighestSkillValue(this))
            CampaignEvents.WorkshopOwnerChangedEvent.AddNonSerializedListener(this, ProgressOwnedWorkshopCount(this))
            CampaignEvents.MobilePartyCreated.AddNonSerializedListener(this, ProgressOwnedCaravanCount(this))
            CampaignEvents.OnSettlementOwnerChangedEvent.AddNonSerializedListener(this, OnSettlementOwnerChanged(this))
            CampaignEvents.KingdomCreatedEvent.AddNonSerializedListener(this, ProgressCreatedKingdomCount(this))
            CampaignEvents.HeroKilledEvent.AddNonSerializedListener(this, OnHeroKilled(this))
            CampaignEvents.BeforeHeroKilledEvent.AddNonSerializedListener(this, OnBeforeHeroKilled(this))
            CampaignEvents.ClanTierIncrease.AddNonSerializedListener(this, ProgressClanTier(this))
            CampaignEvents.OnHideoutBattleCompletedEvent.AddNonSerializedListener(this, OnHideoutBattleCompleted(this))
            CampaignEvents.HeroGainedSkill.AddNonSerializedListener(this, ProgressHeroSkillValue(this))
            CampaignEvents.PlayerInventoryExchangeEvent.AddNonSerializedListener(this, PlayerInventoryExchange(this))
            CampaignEvents.TournamentFinished.AddNonSerializedListener(this, OnTournamentFinish(this))
            CampaignEvents.SiegeCompletedEvent.AddNonSerializedListener(this, OnSiegeCompleted(this))
            CampaignEvents.MapEventEnded.AddNonSerializedListener(this, OnMapEventEnded(this))
            CampaignEvents.OnQuestCompletedEvent.AddNonSerializedListener(this, OnQuestCompleted(this))
            CampaignEvents.OnBuildingLevelChangedEvent.AddNonSerializedListener(this, OnBuildingLevelChanged(this))
            CampaignEvents.OnNewItemCraftedEvent.AddNonSerializedListener(this, OnNewItemCrafted(this))
            CampaignEvents.ClanChangedKingdom.AddNonSerializedListener(this, OnClanChangedKingdom(this))
            CampaignEvents.OnClanDestroyedEvent.AddNonSerializedListener(this, OnClanDestroyed(this))
            CampaignEvents.OnPlayerTradeProfitEvent.AddNonSerializedListener(this, ProgressTotalTradeProfit(this))
            CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick(this))
            CampaignEvents.HeroesMarried.AddNonSerializedListener(this, CheckHeroMarriage(this))
            CampaignEvents.KingdomDecisionConcluded.AddNonSerializedListener(this, CheckKingdomDecisionConcluded(this))
            CampaignEvents.OnMissionStartedEvent.AddNonSerializedListener(this, OnMissionStarted(this))
            CampaignEvents.SettlementEntered.AddNonSerializedListener(this, OnSettlementEnter(this))
            CampaignEvents.OnNewGameCreatedPartialFollowUpEndEvent.AddNonSerializedListener(this, OnNewGameCreatedPartialFollowUpEnd(this))
            CampaignEvents.OnGameLoadFinishedEvent.AddNonSerializedListener(this, OnGameLoadFinished(this))
            CampaignEvents.HeroCreated.AddNonSerializedListener(this, OnHeroCreated(this))
            CampaignEvents.OnIssueUpdatedEvent.AddNonSerializedListener(this, OnIssueUpdated(this))
            CampaignEvents.RulingClanChanged.AddNonSerializedListener(this, OnRulingClanChanged(this))
            CampaignEvents.OnConfigChangedEvent.AddNonSerializedListener(this, OnConfigChanged(this))

            If Not IsNothing(StoryModeManager.Current) Then
                StoryModeEvents.OnStoryModeTutorialEndedEvent.AddNonSerializedListener(this, CheckTutorialFinished(this))
                StoryModeEvents.OnBannerPieceCollectedEvent.AddNonSerializedListener(this, ProgressAssembledDragonBanner(this))
            End If
            Return False
        End Function
    End Class
End Module
