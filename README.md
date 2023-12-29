# HeatForWix
A custom Heat clone for wix that can handle multiple .net core projects.

Very simple problem.  I need to effectively harvest multiple modern .NET core projects into a single wix installer and I do not have an
extra $5k lying around for a FireGiant Support contract.

I have watched several episodes of Rob Mensching's Code Dojo, and I completely respect his insistence that harvesting is a hard problem  I respect every person's 
need to make a living, and so if you have an open source project with a paywall it is entirely reasonable that such a tricky feature would go behind the 
paywall.  However a paywall in an open source project just begs users to code arround it, often by plucking off the low hanging fruit from a much harder
problem.  That is exactly my intention here.  

Rob reports that the hard part of the harvesting problem is suppporting minor upgrades.  Respectfully, having only major upgrades is a completely reasonable 
restriction for me, especially if it saves me $5k.  I also want to take a completely different approach from Rob's design in heat.  Rather than execute a publish
on each assembly, I intend to parse the deps.json file for each assembly to find its dependencies, and then locate the assembly files on disk.  The other
problem I want to solve as creating multiple features with overlapping file sets.  The installer should install the correct set of files for any combination of
installed features.