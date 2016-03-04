Public Class fTutorial

    Private Sub SlCbtn2_Click(sender As Object, e As EventArgs) Handles SlCbtn2.Click
        Dim y As Integer, z As Integer

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) + 1

        'Check last item
        If z > 15 Then Exit Sub

        'Set the new item
        lbl_Selected.Text = z & " / " & 17

        'Build the textbox
        Call TheQuest
    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
        Dim y As Integer, z As Integer

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) - 1

        'Check last item
        If z < 1 Then Exit Sub

        'Set the new item
        lbl_Selected.Text = z & " / " & 17

        'Build the textbox
        Call TheQuest()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Public Sub TheQuest()
        Dim z As Integer = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2)
        Select Case z
            Case Is = 1
                txt_Tutorial.Text = "Welcome to Dev Studio Tycoon. This tutorial will give a general direction of how to play without holding your hand. You can go forward, backwards, or close at anytime. You can move screens around by dragging the blue bar at the top."
            Case Is = 2
                txt_Tutorial.Text = "In front of you lies the main game. On the top-left corner you can find the main menus. Familiarize yourself with what the menus contain. Press pause under Gameplay if you need time."
            Case Is = 3
                txt_Tutorial.Text = "Managing a company isn't easy and you have very little funds. I recommend taking a contract or a loan. Loans are paid back over the course of 3 years automatically, or you can pay it all off at once."
            Case Is = 4
                txt_Tutorial.Text = "Contracts are a great way to build reputation, but you have to meet the deadline. Like real life, you have to understand what you can and cannot accomplish and that takes experience. If you fail to meet a deadline, you will still get paid, but at a discounted rate."
            Case Is = 5
                txt_Tutorial.Text = "If you're a Programmer, you probably have more technical skills so you'll want to focus on contracts with tech points. The same concept applies to Artists with art. Each type of person in the game has a skillset that can be applied to various aspects of contracts, games, engines, and consoles."
            Case Is = 6
                txt_Tutorial.Text = "If you haven't done so, please accept a contract or take a loan. Resume the game if it's paused. When you're ready, let's learn about making your first game - around $50,000 should be good. Don't forget to save with the home button on the bottom."
            Case Is = 7
                txt_Tutorial.Text = "Let's build a new game. Action is a good start. Choose a sub-genre and an interest. If either of these are trending when you release the game, it will increase sales quite a bit!"
            Case Is = 8
                txt_Tutorial.Text = "Select a platform and an engine. An engine is extremely beneficial and will save development time. When you're ready, click Accept and name your game. Let's choose Indie game size since it's just you."
            Case Is = 9
                txt_Tutorial.Text = "Why aren't we hiring someone, you ask? Well you can, but you probably can't afford paying them through development. If you want to hire, then do it now. Waiting until later could really hurt development as you'll spend time training them."
            Case Is = 10
                txt_Tutorial.Text = "You should be developing now and you'll start seeing the bars on the left start to fill. These are development points. At top you'll see ""Pre-Production"" - the development stage you're in. The Full Schedule will appear when you finish your prototype and have a project timeline defined."
            Case Is = 11
                txt_Tutorial.Text = "Each stage focuses on different aspects of the game. The Prototype is focused on the initial outline and the story. Each position affects a stage differently; writers are great in Prototype and designers are great in Level Design. All employees will be beneficial throughout development, but some moreso than others in different stages."
            Case Is = 12
                txt_Tutorial.Text = "When asked if you want to pitch your idea to a publisher, do it. They'll give you some cash upfront and a percentage of all sales. Someday you'll be able to publish your own games, and eventually others! Select a publisher with a good deadline and downpayment. Or do you want more cut of the profits? The choice is yours."
            Case Is = 13
                txt_Tutorial.Text = "The project timeline is defined for you. Click Accept to get a recommendation. If you want to, you can adjust the sliders to your weaknesses. If you're a programmer, for example, you may want to sacrifice programming time and put more effort in art production. Keep in mind the genre too. Action games are influenced by gameplay while role-playing games are influenced by story."
            Case Is = 14
                txt_Tutorial.Text = "When your defined weeks at the bottom matches the defined timeline at the top, click Approve. You will begin developing your first project! When your Production stage is complete, move on to next step."
            Case Is = 15
                txt_Tutorial.Text = "The screen in front of you should be asking who you want to lead the project. Select you since you're it. Typically, you'll want to have a person whose specialty is that stage (i.e. a designer for Level Design) for a bonus. Again, every employee can influence a stage differently and their positions play an important role."
            Case Is = 16
                txt_Tutorial.Text = "Just before the Full Schedule bar is filled, you'll want to market a game. The more you market the game, the more it helps sales. Publishers provide a huge boost and it's expensive to match. The rating of your game is influenced by the development points and the genre. Real-time strategies are more affected by replayability than story, for example. Think about different genres you play and why you love them."
            Case Is = 17
                txt_Tutorial.Text = "I said I wouldn't hold your hand, so this is where I wish you luck. One final tip: Employees should balance your weaknesses (artwork verses technicality) and skills over time. Be sure to give them raises every 3-6 months or they may start requesting paid-time off, or potentially quit. This game is full of strategy, problem solving, and depth. You will never play the same game twice. Good luck!"
        End Select
    End Sub

    Private Sub SlcTheme1_Click(sender As Object, e As EventArgs) Handles SlcTheme1.Click

    End Sub

    Private Sub fTutorial_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TheQuest()
    End Sub
End Class