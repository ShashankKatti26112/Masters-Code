import numpy as np
import seaborn as sns
import matplotlib.pyplot as plt
from sklearn.model_selection import train_test_split
from sklearn.neighbors import KNeighborsClassifier
from sklearn.preprocessing import LabelEncoder
from sklearn.metrics import accuracy_score
import joblib

# Load the Titanic dataset
data = sns.load_dataset("titanic")

# Feature selection
cols_to_drop = ['fare', 'class', 'who', 'adult_male', 'deck', 'embark_town', 'alive', 'alone']
data_new = data.drop(cols_to_drop, axis=1)

# Handle missing values in 'age' column
mean_age = np.round(data_new['age'].mean(), decimals=2)
data_new['age'] = data_new['age'].fillna(mean_age)

# Drop rows with missing values in the 'embarked' column
data_new = data_new.dropna()

# Label Encoding for categorical columns
label_encoder = LabelEncoder()
data_new['sex'] = label_encoder.fit_transform(data_new['sex'])
data_new['embarked'] = label_encoder.fit_transform(data_new['embarked'])

# Prepare features (X) and target (Y)
X = np.array(data_new.iloc[:, 1:])
Y = np.array(data_new.iloc[:, 0])

# Split the data into training and testing sets
x_train, x_test, y_train, y_test = train_test_split(X, Y, train_size=0.8, random_state=3)

# Initialize the KNeighborsClassifier
n_neighbors = 3  # You need to define the number of neighbors
model = KNeighborsClassifier(n_neighbors=n_neighbors)

# Fit the model on the training data
model.fit(x_train, y_train)

# Predict on the test data
y_pred = model.predict(x_test)

# Calculate accuracy
accuracy = accuracy_score(y_test, y_pred)
print(f"Accuracy: {accuracy}")

# Save the model to a file
joblib.dump(model, "titanic.pkl")

# Load the model from the file
loaded_model = joblib.load("titanic.pkl")

# Example prediction
example_prediction = loaded_model.predict([[1, 0, 20, 2, 0, 1]])
print(f"Example Prediction: {example_prediction}")
